using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambaExpressions
{
    public class Book
    {
        //private string Title;
        //private int price;

            public Book() {
            Title = "";
            Price = 0;
        }
            public Book(string title, int price)
            {
                Title = title;
                Price = price;
            }

            public int Price { get; set; }
            public string Title { get; set; }
    }
}
