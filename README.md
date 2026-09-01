# 🎓 Student Management System - نظام إدارة الطلاب

نظام بسيط لإدارة بيانات الطلاب باستخدام لغة C#، يهدف إلى تخزين وعرض بيانات الطلاب والتحقق من حالتهم الدراسية.

---

## 📋 قائمة المحتويات

- [الهدف من المشروع](#-الهدف-من-المشروع)
- [المميزات](#-المميزات)
- [التقنيات المستخدمة](#-التقنيات-المستخدمة)
- [هيكل المشروع](#-هيكل-المشروع)
- [كيفية التشغيل](#-كيفية-التشغيل)
- [المخرجات المتوقعة](#-المخرجات-المتوقعة)
- [التحديات التي واجهتني](#-التحديات-التي-واجهتني)
- [الدروس المستفادة](#-الدروس-المستفادة)
- [المؤلف](#-المؤلف)
- [شكر وتقدير](#-شكر-وتقدير)

---

## 🎯 الهدف من المشروع

بناء نظام لإدارة بيانات الطلاب يتضمن:

- ✅ تخزين معلومات الطالب (الاسم، العمر، الدرجة)
- ✅ عرض بيانات الطالب بشكل منظم
- ✅ التحقق من حالة الطالب (نجاح/رسوب)
- ✅ تصنيف الدرجة إلى مستويات (Excellent, Very Good, Good, Pass, Failed)
- ✅ تطبيق مفاهيم البرمجة الكائنية (OOP) في C#

---

## ✨ المميزات

| الدالة | الوصف |
|--------|-------|
| `DisplayInfo()` | عرض بيانات الطالب (الاسم، العمر، الدرجة) |
| `IsPassed()` | التحقق من نجاح أو رسوب الطالب |
| `GetGradeStatus()` | تصنيف الدرجة إلى أحد المستويات الخمسة |

### تصنيف الدرجات:

| النطاق | التقييم |
|--------|---------|
| 90 - 100 | Excellent |
| 75 - 89  | Very Good |
| 60 - 74  | Good |
| 50 - 59  | Pass |
| أقل من 50 | Failed |

---

## 🛠️ التقنيات المستخدمة

- **لغة البرمجة:** C#
- **إطار العمل:** .NET
- **مفاهيم البرمجة:**
  - Classes و Objects
  - Constructor لتهيئة البيانات
  - Encapsulation (Setter & Getter)
  - Methods
  - String Interpolation

---

## 📁 هيكل المشروع
class Student
{
    // Fields
    string name;
    int age;
    float grade;
    
    // Constructor
    public Student(string name, int age, float grade)
    
    // Properties (Setter & Getter)
    public void SetName(string Name)
    public string GetName()
    // ... etc
    
    // Methods
    public string DisplayInfo()
    public void IsPassed()
    public void GetGradeStatus()
    
    // Main
    static void Main()
}

المخرجات المتوقعة

على مجهودوا معانا فى المحاضرات Mohamed Essam - اولا حابب اشكر البشمهندس
I am Ibrahim Mohamed El-Ghazaly
الحمد الله اني انشاءت هذا البروجيكت دون استخدام الذكاء الاصطناعى ابدا والله اعلم
بحيث اشوف كدة ان دا اللى كان مطلوب chatgpt ولاكن راجعت الكود على
========== Thank you ==========

========== This Is Project ==========

========== Student 1 ==========
Name: Ahmed
Age: 20
Grade: 85
Status: Passed
Grade Status: Very Good
========== Student 2 ==========
Name: Mohamed
Age: 21
Grade: 45
Status: Failed
Grade Status: Failed
========== Student 3 ==========
Name: Omar
Age: 19
Grade: 70
Status: Passed
Grade Status: Good

=== Code Execution Successful ===
