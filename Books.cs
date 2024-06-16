using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace hw_15._05
{
    public class Books
    {
        public List<Book> book_list = new List<Book>();
        public static List<Book> operator+ (Books books, Book book)
        {
            books.book_list.Add(book);
            return books.book_list;
        }
        public static List<Book> operator- (Books books, Book book)
        {
            books.book_list.RemoveAll(b => b.Title == book.Title && b.Author == book.Author && b.Year == book.Year);
            return books.book_list;
        }
        public bool FindBook(Books books, Book book)
        {
            return books.book_list.Exists(b => b.Title == book.Title && b.Author == book.Author && b.Year == book.Year);
        }
        public void Print()
        {
            Console.WriteLine("Все книги: \nTitle\tAuthor\tYear");
            foreach (Book book in book_list)
            {
                Console.WriteLine($"{book.Title}\t{book.Author}\t{book.Year}");
            }
            Console.WriteLine();
        }
    }
}
