using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_inheritance
{
    public class Person
    {
        protected string name;
        protected int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { if (age > 0) { age = value; } else if (age <= 0) { age = 0; } }
        }

        public Person()
        {
            name = "No name";
            age = 0;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        static public Person[] people = new Person[]
        {
            new Person("Ваня", 12), new Person("Саша", 14),
            new Person("Ксюша", 19), new Person("Алина", 17),
            new Person("Маша", 20), new Person("Юра", 16)
        };

        public virtual Person Clone()
        {
            return new Person(name, age);
        }

        public static Person RandomPerson()
        {
            Random random = new Random();
            Person person = people[random.Next(people.Length)].Clone();
            return person;
        }

        public override string ToString()
        {
            string str = "";
            str += "Имя: " + name + "; Возраст: " + age + "; ";
            return str;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() + age.GetHashCode(); ;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Person))
            {
                return false;
            }
            Person other = (Person)obj;
            if ((other.Age == Age) && (other.Name == Name))
            {
                return true;
            }
            return false;
        }

        public virtual void Print()
        {
            Console.WriteLine("Имя: {0}; Возраст: {1}", name, age);
        }
    }

    public class Student : Person
    {
        int course = 1;
        Teacher teacher = new Teacher();

        public Student() : base()
        {
            course = 1;
        }

        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public Teacher Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }

        public Student(string name, int age, int course) : base(name, age)
        {
            this.course = course;
        }

        public Student(string name, int age, int course, Teacher teacher) : base(name, age)
        {
            Course = course;
            Teacher = teacher;
        }

        static public Student[] students = new Student[]
        {
                new Student("Паша", 20, 2), new Student("Маша", 21, 4),
                new Student("Юра", 20, 3), new Student("Илья", 19, 1),
                new Student("Оля", 19, 2), new Student("Миша", 21, 3)
        };

        public override Student Clone()
        {
            Student student = new Student();
            student.Course = course;
            student.Teacher = teacher;
            student.Age = age;
            student.Name = name;
            return student;
        }

        public static Student RandomStudent()
        {
            Random random = new Random();
            Student student = students[random.Next(0, students.Length)].Clone();
            return student;
        }

        public static Student RandomStudent(List<Teacher> List_teachers)
        {
            Random random = new Random();
            Student Rstudent = students[random.Next(0, students.Length)].Clone();
            Rstudent.teacher = List_teachers[random.Next(0, List_teachers.Count)];
            Rstudent.teacher.List_teachers.Add(Rstudent);
            return Rstudent;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetHashCode()
        {
            int Sum = base.GetHashCode() + course.GetHashCode();
            if (teacher != null)
                Sum += teacher.GetHashCode();
            return Sum;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student)) return false;
            else
            {
                Student student = (Student)obj;
                if ((student.Name == this.Name) && (student.Age == this.Age) && (student.Course == this.Course))
                    if (teacher == null)
                        if (student.Teacher == null) return true;
                        else return false;
                    else if (student.Teacher == null) return false;
                    else return teacher.Equals(student.Teacher);
            }
            return false;
        }

        public override void Print()
        {
            base.Print();
            Console.Write($"Курс: {Course}; Препод: ");
            if (teacher == null) Console.WriteLine("Отсутствует");
            else Console.WriteLine(teacher);
        }

        public static void Ancestors()
        {
            PrintAncestors(typeof(Student));
            Console.WriteLine(typeof(object).Name);
        }

        static void PrintAncestors(Type type)
        {
            Console.WriteLine(type.Name);


            if (type.BaseType != null && type.BaseType != typeof(object))
            {
                PrintAncestors(type.BaseType); // Через рекурсию вызываем для предка его предка, пока мы не достигнем базового класса (object)
            }
        }
    }

    public class Teacher : Person
    {

    }

}
