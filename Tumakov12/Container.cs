using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov12
{
    public class Container
    {
        public delegate List<Book> Sorting(List<Book> books);
        public List<Book> Books { get; set; }
        public Container(List<Book> books)
        {
            Books = books;
        }
        public List<Book> SortingBooks(Sorting del)
        {
            return del(Books);
        }
    }
}
