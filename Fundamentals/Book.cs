using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class Book : Product
    {
        //private int Isbn;
        //private string Title;

        public Book(int isbn,string title) { 
            Isbn=isbn;
            Title=title;
        }

        public int Isbn { get; set; }
        public string Title { get; set; }

    }
}
