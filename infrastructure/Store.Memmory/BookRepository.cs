using System;
using System.Linq;

namespace Store.Memmory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12312-31231", "D. Knuth", "Art of Programming, Vol. 1", 
                "This volume begins with basic programming concepts and techniques",
                7.19m),
            new Book(2, "ISBN 12312-31232", "M. Flowler", "Refactoring",
                "As the application of object technology--particulary the Java programming...",
                12.45m),
            new Book(3, "ISBN 12312-31233", "B. Kernighan, D. Ritchie", "C Programming Language",
                "Known as the bible of C, this classic bestseller introduces...",
                14.98m)
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                                    || book.Title.Contains(query))
                        .ToArray();
        }

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    }
}
