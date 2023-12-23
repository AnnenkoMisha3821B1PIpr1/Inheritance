using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_inheritance
{
    public class Book
    {
        public string Name_Book;
        public string Name_Author;
        public int Price_Book;

        public Book(string Name_book, string Name_author, int Price_book)
        {
            Name_Book = Name_book;
            Name_Author = Name_author;
            Price_Book = Price_book;
        }

        public Book()
        {
            Name_Book = " "; // с пробелом или без лучше?
            Name_Author = " ";
            Price_Book = -1; // -1 или лучше 0?
        }

        public string NameBook
        {
            get { return Name_Book; }
            set { Name_Book = value; }
        }

        public string NameAuthor
        {
            get { return Name_Author; }
            set { Name_Author = value; }
        }

        public int PriceBook
        {
            get { return Price_Book; }
            set { Price_Book = value; }
        }

        public virtual void Print()
        {
            Console.WriteLine("Название книги: {0}\nАвтор данной книги: {1}\nСтоимость книги: {2}", Name_Book, Name_Author, Price_Book);
        }
    }

    public class BookGenre : Book
    {
        public string genre;

        public BookGenre(string Name_Book, string Name_Author, int Price_Book, string genre_) : base(Name_Book, Name_Author, Price_Book)
        {
            genre = genre_;
        }

        public BookGenre() : base()
        {
            genre = " ";
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Жанр книги: {0}", genre);
        }
    }

    public sealed class BookGenrePubl : BookGenre
    {
        public string Editor;

        public BookGenrePubl(string Name_Book, string Name_Author, int Price_Book, string genre, string editor) : base(Name_Book, Name_Author, Price_Book, genre)
        {
            Editor = editor;
        }

        public BookGenrePubl() : base()
        {
            Editor = " ";
        }

        public string Editor_
        {
            get { return Editor; }
            set { Editor = value; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("", Editor);
        }
    }
}
