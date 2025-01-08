import requests
import os
import re
from bs4 import BeautifulSoup

# اسم المستخدم الخاص بك على Codeforces
handle = "horse-13"  # غير هذا إلى اسم المستخدم الخاص بك

# عمل طلب للحصول على البيانات
def get_solutions(handle, from_val=1, count=100):
    url = f"https://codeforces.com/api/user.status?handle={handle}&from={from_val}&count={count}"
    response = requests.get(url)
    return response.json()

# دالة لتنظيف الأسماء من الرموز غير الصالحة في Windows
def clean_filename(filename):
    # إزالة المسافات الزائدة
    filename = filename.strip()
    # استبدال الرموز غير الصالحة
    filename = re.sub(r'[<>:"/\\|?*]', '_', filename)
    return filename

# دالة لجلب الكود الفعلي من الحل
def get_submission_code(contest_id, submission_id):
    submission_url = f"https://codeforces.com/contest/{contest_id}/submission/{submission_id}"
    response = requests.get(submission_url)
    if response.status_code == 200:
        # جلب الكود من صفحة الحل
        soup = BeautifulSoup(response.text, 'html.parser')
        code = soup.find('pre', {'id': 'program-source-text'})
        if code:
            return code.text
    return None

# دالة لحفظ الحلول
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

        # جلب الكود الفعلي
        code = get_submission_code(contest_id, submission_id)
        if code is None:
            print(f"لم يتم العثور على الكود للـ submission {submission_id}.")
            code = "Code not available"

        # تحديد الامتداد بناءً على اللغة
        if "C++" in language:
            extension = "cpp"
        elif "C#" in language:
            extension = "cs"
        elif "Python" in language:
            extension = "py"
        elif "Java" in language:
            extension = "java"
        else:
            extension = "txt"

        with open(os.path.join(problem_folder, f"{problem_code}_{cleaned_problem_name}.{extension}"), "w", encoding="utf-8") as solution_file:
            solution_file.write(code)

# استرجاع الحلول عبر التكرار
def fetch_all_solutions(handle):
    from_val = 1
    count = 100
    all_submissions = []
    
    while True:
        data = get_solutions(handle, from_val, count)
        if data["status"] == "OK":
            submissions = data["result"]
            if not submissions:
                break
            all_submissions.extend(submissions)
            from_val += count  # تحديث قيمة from لجلب الصفحة التالية
        else:
            print("Error fetching data!")
            break
    
    return all_submissions

# استرجاع جميع الحلول
submissions = fetch_all_solutions(handle)
save_solutions(submissions)
