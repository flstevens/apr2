using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buch
{
    class Program
    {
        static void Main(string[] args)
        {
            Person max = new Person();
            max.Firstname = "Max";
            max.Surname = "Huber";

            Book b = new Book();
            b.Author = max;

            Page p1 = new Page() { Text = "Lorem", Pagenumber = "1" };
            b.Pages.Add(p1);

            Page p2 = new Page() { Text = "Lorem 2", Pagenumber = "2" };
            b.Pages.Add(p2);
           
            Console.WriteLine(b.Author.Firstname);
            Console.WriteLine(String.Format("{0} {1}", b.Author.Firstname, b.Author.Surname));



            Console.ReadLine();
        }
    }
    /*
     * Seiten 
     * Cover
     * Title
     * Ator
     * verlag
     * Preis
     * ...
     */
     class Book
    {
        public string Title { get; set; }
        public Person Author { get; set; }

        public List<Page> Pages { get; set; }

        public Book()
        {
            Pages = new List<Page>();
        }
    }

    class Person
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }

    }

    class Page
    {
        public string Text { get; set; }
        public string Pagenumber { get; set; }
    }
}
