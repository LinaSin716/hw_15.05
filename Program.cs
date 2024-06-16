namespace hw_15._05
{
    internal class Program
    {
        // без индексаторов
        static void Main(string[] args)
        {
            // Номер 1
            
            Console.WriteLine("Номер 1\n");

            Books books = new Books();
            books.book_list = new List<Book>
            {
                new Book("book1", "author1", 2000),
                new Book("book2", "author1", 1996),
                new Book("book3", "author2", 2006),
                new Book("book4", "author2", 2004),
                new Book("book5", "author1", 2020)
            };

            books.Print();

            Console.WriteLine("Добавим книгу book10 и удалим книгу book3\n");

            books.book_list = books + new Book("book10", "author3", 1256);
            books.book_list = books - new Book("book3", "author2", 2006);

            books.Print();

            Console.Write($"Есть ли книга book4 от автора author2 2004-го года: ");
            if (books.FindBook(books, new Book("book4", "author2", 2004))) Console.WriteLine("Есть");
            else Console.WriteLine("Нет");

            Console.Write($"Есть ли книга book4 от автора author1 2004-го года: ");
            if (books.FindBook(books, new Book("book4", "author1", 2004))) Console.WriteLine("Есть");
            else Console.WriteLine("Нет");


            // 2
            Console.WriteLine("\n\nНомер 2\n");

            Matrix matrix1 = new Matrix(
                new int[,]{ { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } });
            Matrix matrix2 = new Matrix(
                new int[,] { { 4, 1, 3, 2 }, { 8, 5, 7, 6 }, { 12, 9, 11, 10 } });
            
            Console.WriteLine("matrix1: ");
            matrix1.Print();

            Console.WriteLine("matrix2: ");
            matrix2.Print();

            Console.WriteLine("matrix1 + matrix2: ");
            Matrix matrix = matrix1 + matrix2;
            matrix.Print();

            Console.WriteLine("matrix1 - matrix2: ");
            matrix = matrix1 - matrix2;
            matrix.Print();

            Console.WriteLine("matrix1 * 5: ");
            matrix = matrix1 * 5;
            matrix.Print();

            Console.Write("matrix1 == matrix2: ");
            Console.WriteLine(matrix1 == matrix2);

            Console.Write("matrix1 != matrix2: ");
            Console.WriteLine(matrix1 != matrix2);

            Console.Write("matrix1 = matrix2: ");
            Console.WriteLine(matrix1.Equals(matrix2));
            

        }
    }
}