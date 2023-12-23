using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookGenrePubl bookGenrePubl = new BookGenrePubl("Война и мир", "Л.Н. Толстой", 400, "Роман-эпопея", "Русский вестник");
            bookGenrePubl.Print();           

            Console.ReadKey();
        }
    }
}
