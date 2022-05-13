using BookApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DataAccess.Abstract
{
    public interface IBookRepository
    {
        List<Book> GetAllBook();

        Book GetBookById(int id);

        Book CreateBook(Book book);

        Book UpdateBook(Book book);

        void DeleteBook(int id);
    }
}
