//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Task_1_inheritance
//{
//    public class Student : Person
//    {
//        int course = 1;
//        Teacher teacher;

//        public Student() : base()
//        {
//            course = 1;
//            teacher = null;
//        }

//        public int Course
//        {
//            get { return course; }
//            set { course = value; }
//        }

//        public Teacher Current_Teacher
//        {
//            get { return teacher; }
//            set { teacher = value; }
//        }

//        public Student(string name, int age, int course, Teacher teacher = null) : base(name, age)
//        {
//            Course = course;
//            Current_Teacher = teacher;
//        }

//        static public Student[] students = new Student[]
//        {
//            new Student("Паша", 20, 2), new Student("Маша", 21, 4),
//            new Student("Юра", 20, 3), new Student("Илья", 19, 1),
//            new Student("Оля", 19, 2), new Student("Миша", 21, 3)
//        };

//        public override Student Clone()
//        {
//            if (teacher == null)
//                return new Student(Name, Age, Course, null);
//            Teacher TeacherClone = teacher.Clone();
//            foreach (var student in TeacherClone.Students)
//            {
//                if (this.Equals(student))
//                {
//                    return student;
//                }
//            }
//            return new Student(Name, Age, Course, TeacherClone);
//        }

//        public static Student RandomStudaent(Random random = null)
//        {
//            if (random != null)
//            {
//                return students[random.Next(students.Length)];
//            }
//            else
//            {
//                return students[(new Random()).Next(students.Length)].Clone();
//            }
//        }
//        public override string ToString()
//        {
//            return base.ToString();
//        }

//        public override int GetHashCode()
//        {
//            int Sum = base.GetHashCode() + course.GetHashCode();
//            if (teacher != null)
//                Sum += teacher.GetHashCode();
//            return Sum;
//        }

//        public override bool Equals(object obj)
//        {
//            if (!(obj is Student)) return false;
//            else
//            {
//                Student student = (Student)obj;
//                if ((student.Name == Name) && (student.Age == Age) && (student.Course == Course))
//                    if (teacher == null)
//                        if (student.Current_Teacher == null) return true;
//                        else return false;
//                    else if (student.Current_Teacher == null) return false;
//                    else return teacher.Equals(student.Current_Teacher);
//            }
//            return false;
//        }

//        public static void Ancestors()
//        {
//            PrintAncestors(typeof(Student));
//            Console.WriteLine(typeof(object).Name);
//        }

//        static void PrintAncestors(Type type)
//        {
//            Console.WriteLine(type.Name);


//            if (type.BaseType != null && type.BaseType != typeof(object))
//            {
//                PrintAncestors(type.BaseType); // Через рекурсию вызываем для предка его предка, пока мы не достигнем базового класса (object)
//            }
//        }
//    }

//}
