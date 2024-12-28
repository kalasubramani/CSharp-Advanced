using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title="Harry Potter",Price=49},
                new Book(){Title="Snow White",Price=75 },
                new Book(){Title="Skeleton curse",Price= 38 }
            };
        }
    }
}
