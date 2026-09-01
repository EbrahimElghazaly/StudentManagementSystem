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
StudentManagementSystem/
│
├── Program.cs # الكود المصدري الرئيسي
├── StudentManagementSystem.csproj # ملف تعريف المشروع
└── README.md # شرح المشروع (هذا الملف)

### هيكل الكود:

```csharp
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
🔧 التحديات التي واجهتني
المشكلة: عدم ظهور اللغة العربية في الـ Console
عند تشغيل البرنامج، كانت النصوص العربية تظهر بشكل مشوه أو لا تظهر نهائياً.

السبب:
الـ Command Prompt في Windows يستخدم ترميزاً افتراضياً لا يدعم اللغة العربية (Code Page 1252)، بينما اللغة العربية تحتاج إلى ترميز UTF-8 (Code Page 65001).

الحل:
1. في الكود:

csharp
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
2. في إعدادات Visual Studio:

File → Save As... → Save with Encoding → Unicode (UTF-8 with signature)

3. في الـ Command Prompt:

تغيير الخط إلى Consolas أو Lucida Console

كتابة الأمر: chcp 65001

📚 الدروس المستفادة
📘 فهم عميق لمفاهيم الـ OOP في C#

📗 كيفية التعامل مع المشكلات التقنية وحلها خطوة بخطوة

📕 أهمية الترميز الصحيح للغات في البرمجة (Encoding)

📙 الصبر والاستمرار حتى ينجح الكود

📒 استخدام Setter & Getter لتطبيق مبدأ Encapsulation

👨‍💻 المؤلف
Ibrahim Mohamed El-Ghazaly

🙏 شكر وتقدير
أود أن أشكر الأستاذ/ المهندس Mohamed Essam على:

📚 مجهوده الكبير معنا في المحاضرات

🎯 شرحه الواضح والمبسط للمفاهيم

💡 دعمه المستمر وتشجيعه لنا

كان له دور كبير في فهمي للبرمجة بشكل عام ولغة C# بشكل خاص.

جزاك الله خيراً على ما تقدمه لنا من علم وخبرة. 🙏

📜 الترخيص
هذا المشروع مقدم للأغراض التعليمية.

🔗 روابط مفيدة
Microsoft C# Documentation

.NET Documentation

GitHub Guides

⭐ Show Your Support
إذا أعجبك المشروع، لا تنسى أن تترك ⭐ على GitHub!

##المخرجات المتوقعة

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
