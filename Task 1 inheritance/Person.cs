//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Task_1_inheritance
//{
//    public class Person
//    {
//        string name;
//        int age;

//        public Person()
//        {
//            name = "No name";
//            age = 0;
//        }

//        public Person(string Name, int Age)
//        {
//            name = Name;
//            age = Age;
//        }

//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }

//        public int Age
//        {
//            get { return age; }
//            set { if (value < 0) value = 0; age = value; }
//        }

//        static public Person[] people = new Person[]
//        {
//            new Person("Ваня", 12), new Person("Саша", 14),
//            new Person("Ксюша", 19), new Person("Алина", 17),
//            new Person("Маша", 20), new Person("Юра", 16)
//        };

//        public static Person RandomPerson(Random random = null)
//        {
//            if (random != null)
//            {
//                return people[random.Next(people.Length)];
//            }
//            else
//            {
//                return people[(new Random()).Next(people.Length)].Clone();
//            }
//        }

//        public virtual Person Clone()
//        {
//            return new Person(name, age);
//        }

//        public override string ToString()
//        {
//            return name;
//        }

//        public override int GetHashCode()
//        {
//            return name.GetHashCode() + age.GetHashCode();
//        }

//        public override bool Equals(object obj)
//        {
//            if (!(obj is Person))
//            {
//                return false;
//            }
//            Person other = (Person)obj;
//            if ((other.Age == Age) && (other.Name == Name))
//            {
//                return true;
//            }
//            return false;
//        }

//        public virtual void Print()
//        {
//            Console.WriteLine("Имя: {0}; Возраст: {1}", name, age);
//        }
//    }

//}
