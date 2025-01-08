import requests
import os
import re  # لإزالة الأحرف غير المسموح بها

# اسم المستخدم الخاص بك على Codeforces
handle = "horse-13"  # استبدل 'horse-13' باسم المستخدم الخاص بك

# API URL
url = f"https://codeforces.com/api/user.status?handle={handle}"

# عمل طلب للحصول على البيانات
response = requests.get(url)
data = response.json()

if data["status"] == "OK":
    submissions = data["result"]
    
    # إنشاء مجلد لتخزين الحلول
    if not os.path.exists("solutions"):
        os.mkdir("solutions")
    
    for submission in submissions:
        if submission["verdict"] == "OK":  # التأكد من أن الحل صحيح
            problem_name = submission["problem"]["name"]
            contest_id = submission["contestId"]
            submission_id = submission["id"]
            language = submission["programmingLanguage"]
            
            # تنظيف اسم المسألة من الأحرف غير المسموح بها
            sanitized_problem_name = re.sub(r'[<>:"/\\|?*]', '', problem_name)
            
            # تحديد امتداد الملف بناءً على اللغة
            extension = "txt"  # افتراضيًا
            if "C++" in language:
                extension = "cpp"
            elif "Python" in language:
                extension = "py"
            elif "Java" in language:
                extension = "java"
            
            # تحميل الحل
            solution_url = f"https://codeforces.com/contest/{contest_id}/submission/{submission_id}"
            solution_content = f"Problem: {problem_name}\nURL: {solution_url}\n\nCodeforces doesn't allow scraping directly. Add manually."
            
            # تحديد اسم الملف
            filename = f"solutions/{contest_id}_{sanitized_problem_name}.{extension}"
            
            # حفظ الحل في ملف
            with open(filename, "w", encoding="utf-8") as f:
                f.write(solution_content)
    print("All solutions have been saved in the 'solutions' folder!")
else:
    print("Error fetching data!")
