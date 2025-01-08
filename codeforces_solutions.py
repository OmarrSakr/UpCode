import requests
import os
import re

# اسم المستخدم الخاص بك على Codeforces
handle = "horse-13"  # غير هذا إلى اسم المستخدم الخاص بك

# URL لجلب الحلول
url = f"https://codeforces.com/api/user.status?handle={handle}&from=1&count=100"

# عمل طلب للحصول على البيانات
def get_solutions(url):
    response = requests.get(url)
    return response.json()

# دالة لتنظيف الأسماء من الرموز غير الصالحة في Windows
def clean_filename(filename):
    # إزالة المسافات الزائدة
    filename = filename.strip()
    # استبدال الرموز غير الصالحة
    filename = re.sub(r'[<>:"/\\|?*]', '_', filename)
    return filename

def save_solutions(submissions):
    solutions_folder = "Codeforces_Solutions"
    if not os.path.exists(solutions_folder):
        os.mkdir(solutions_folder)
    
    for submission in submissions:
        problem_name = submission["problem"]["name"]
        contest_id = submission["contestId"]
        problem_id = submission["problem"]["index"]
        language = submission["programmingLanguage"]
        submission_id = submission["id"]
        verdict = submission.get("verdict", "Unknown")

        # تنظيف اسم المسألة
        cleaned_problem_name = clean_filename(problem_name)

        # تحديد اسم المجلد بناءً على رقم المسألة واسمها
        problem_code = f"{contest_id}_{problem_id}"
        problem_folder_name = f"{problem_code}_{cleaned_problem_name}"
        problem_folder = os.path.join(solutions_folder, problem_folder_name)
        
        if not os.path.exists(problem_folder):
            os.mkdir(problem_folder)

        with open(os.path.join(problem_folder, "info.txt"), "w", encoding="utf-8") as info_file:
            info_file.write(f"Problem ID: {problem_code}\n")
            info_file.write(f"Problem Name: {problem_name}\n")
            info_file.write(f"Contest ID: {contest_id}\n")
            info_file.write(f"Problem URL: https://codeforces.com/contest/{contest_id}/problem/{problem_id}\n")
            info_file.write(f"Language: {language}\n")
            info_file.write(f"Verdict: {verdict}\n")
            info_file.write(f"Submission ID: {submission_id}\n")

        # تحديد الامتداد بناءً على اللغة
        if "C++" in language:
            extension = "cpp"
            solution_code = submission["programmingLanguage"]
        elif "C#" in language:
            extension = "cs"
            solution_code = submission["programmingLanguage"]
        elif "Python" in language:
            extension = "py"
            solution_code = submission["programmingLanguage"]
        elif "Java" in language:
            extension = "java"
            solution_code = submission["programmingLanguage"]
        else:
            extension = "txt"
            solution_code = submission["programmingLanguage"]

        with open(os.path.join(problem_folder, f"{problem_code}_{cleaned_problem_name}.{extension}"), "w", encoding="utf-8") as solution_file:
            solution_file.write(solution_code)

# استرجاع الحلول
data = get_solutions(url)
if data["status"] == "OK":
    submissions = data["result"]
    save_solutions(submissions)
else:
    print("Error fetching data!")
