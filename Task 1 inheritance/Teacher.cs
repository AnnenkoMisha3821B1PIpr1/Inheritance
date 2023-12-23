//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Task_1_inheritance
//{
//    public class Teacher : Person
//    {
//        List<Student> students = new List<Student>();
//        public List<Student> Students
//        {
//            get { return students; }
//            set
//            {
//                students.Clear();
//                students.AddRange(value);
//            }
//        }

//        public Teacher() : base() { }

//        public Teacher(string name, int age, List<Student> students = null) : base(name, age)
//        {
//            if (students != null)
//            {
//                this.students.AddRange(students);
//                foreach (var student in students)
//                {
//                    student.Current_Teacher = this;
//                }
//            }
//        }

//        public static Teacher[] teachers = new Teacher[]
//        {
//            new Teacher("Виктор", 30), new Teacher("Мария", 40),
//            new Teacher("Елена", 27), new Teacher("Павел", 45),
//            new Teacher("Ирина", 35), new Teacher("Николя", 32)
//        };

//        public override Teacher Clone()
//        {
//            Teacher TeacherClone = new Teacher(Name, Age, null);
//            List<Student> list = new List<Student>();
//            Student StudentClone = null;
//            foreach (var stud in students)
//            {
//                StudentClone = new Student(stud.Name, stud.Age, stud.Course, TeacherClone);
//                list.Add(StudentClone);
//            }
//            TeacherClone.students.AddRange(list);
//            return TeacherClone;
//        }

//        public static Teacher RandomTeacher(Random random = null)
//        {
//            if (random != null)
//            {
//                return teachers[random.Next(teachers.Length)];
//            }
//            else
//            {
//                return teachers[(new Random()).Next(teachers.Length)].Clone();
//            }
//        }
//    }
//}
