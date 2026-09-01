using System;
using System.Text;

namespace depi
{
    class Student
    {
        string name;
        int age;
        float grade;

        public Student(string name, int age, float grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public void SetName(string Name)
        {
            name = Name;
        }
        public string GetName()
        {
            return name;
        }

        public void SetAge(int Age)
        {
            age = Age;
        }
        public int GetAge()
        {
            return age;
        }

        public void SetGrade(float Grade)
        {
            grade = Grade;
        }
        public float GetGrade()
        {
            return grade;
        }

        public string DisplayInfo()
        {
            return $"Name: {name}\nAge: {age}\nGrade: {grade}";
        }

        public void IsPassed()
        {
            if (grade >= 50)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        public void GetGradeStatus()
        {
            if (grade >= 90 && grade <= 100)
                Console.WriteLine("Excellent");
            else if (grade >= 75 && grade <= 89)
                Console.WriteLine("Very Good");
            else if (grade >= 60 && grade <= 74)
                Console.WriteLine("Good");
            else if (grade >= 50 && grade <= 59)
                Console.WriteLine("Pass");
            else if (grade < 50 && grade >= 0)
                Console.WriteLine("Failed");
            else
                Console.WriteLine("Invalid Grade");
        }

        static void Main()
        {
            //  لان مكنش راضي يطبع عربي عندى على الحهاز AI الجزء دا انا جبتوا من ال 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("على مجهودوا معانا فى المحاضرات Mohamed Essam - اولا حابب اشكر البشمهندس");
            Console.WriteLine("I am Ibrahim Mohamed El-Ghazaly");
            Console.WriteLine("الحمد الله اني انشاءت هذا البروجيكت دون استخدام الذكاء الاصطناعى ابدا والله اعلم");
            Console.WriteLine("بحيث اشوف كدة ان دا اللى كان مطلوب chatgpt ولاكن راجعت الكود على");
            Console.WriteLine("========== Thank you ==========");
            Console.WriteLine("\n========== This Is Project ==========\n");

            Console.WriteLine("========== Student 1 ==========");
            Student stu1 = new Student("Ahmed", 20, 85);
            Console.WriteLine(stu1.DisplayInfo());
            Console.Write("Status: ");
            stu1.IsPassed();
            Console.Write("Grade Status: ");
            stu1.GetGradeStatus();

            Console.WriteLine("========== Student 2 ==========");
            Student stu2 = new Student("Mohamed", 21, 45);
            Console.WriteLine(stu2.DisplayInfo());
            Console.Write("Status: ");
            stu2.IsPassed();
            Console.Write("Grade Status: ");
            stu2.GetGradeStatus();

            Console.WriteLine("========== Student 3 ==========");
            Student stu3 = new Student("Omar", 19, 70);
            Console.WriteLine(stu3.DisplayInfo());
            Console.Write("Status: ");
            stu3.IsPassed();
            Console.Write("Grade Status: ");
            stu3.GetGradeStatus();

        }
    }
}