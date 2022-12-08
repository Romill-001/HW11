using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov12
{

    internal class Program
    {
        static List<Book> SortBooksByName(List<Book> books)
        {
            return new List<Book>(from book in books orderby book.Name select book);
        }
        static List<Book> SortBooksByAuthor(List<Book> books)
        {
            return new List<Book>(from book in books orderby book.Author select book);
        }
        static List<Book> SortBooksByPublisher(List<Book> books)
        {
            return new List<Book>(from book in books orderby book.Publisher select book);
        }
        static void Main(string[] args)
        {
            BankAcc acc= new BankAcc(1000,123);
            BankAcc acc1 = new BankAcc(1000,123);
            Console.WriteLine(acc == acc1);
            Console.WriteLine(acc != acc1);
            Console.WriteLine(acc.GetHashCode());
            Console.WriteLine(acc.Equals(acc1));
            Console.WriteLine(acc1.Equals(acc));
            Console.WriteLine(acc.ToString());
            Console.WriteLine(acc1.ToString());
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>");
            RationalDigits r = new RationalDigits(3,5);
            RationalDigits r1 = new RationalDigits(2,5);
            Console.WriteLine(r == r1);
            Console.WriteLine(r != r1);
            Console.WriteLine(r > r1);
            Console.WriteLine(r < r1);
            Console.WriteLine((r + r1).ToString());
            Console.WriteLine((r - r1).ToString());
            Console.WriteLine((r++).ToString());
            Console.WriteLine((r1--).ToString());
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>");
            MDigits m1 = new MDigits(3,5);
            MDigits m2 = new MDigits(2,5);
            Console.WriteLine(m1 == m2);
            Console.WriteLine(m1 != m2);
            Console.WriteLine(m1.Equals(m2));
            Console.WriteLine((m1+m2).ToString());
            Console.WriteLine((m2 - m1).ToString());
            Console.WriteLine((m1 * m2).ToString());
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>");
            List<Book> lst = new List<Book> 
            {
                new Book("Гарри Потер Часть 1", "ЖКРоулинг", "ВорнерБрозерс"),
                new Book("Властелин Колец", "Толкин", "Студия Мельница"),
                new Book("Приключения Бебры", "Бебрик", "СтудияБебра"),
                new Book("Хранители", "Антон Гурченко", "ОгурчикОст"),
                new Book("Сигма", "Илья Ро_0манов", "Литерали ми"),
                new Book("Драйв", "Азат Залелетдинов", "Литерали ми")
            };
            Container c1 = new Container(lst);
            Console.WriteLine("Отсортированные книги по имени\n>>>");
            foreach (var item in c1.SortingBooks(new Container.Sorting(SortBooksByName)))
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Отсортированные книги по автору\n>>>");
            foreach (var item in c1.SortingBooks(new Container.Sorting(SortBooksByAuthor)))
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Отсортированные книги по издательству\n>>>");
            foreach (var item in c1.SortingBooks(new Container.Sorting(SortBooksByPublisher)))
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
