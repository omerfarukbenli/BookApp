using BookApp.Business.Abstract;
using BookApp.DataAccess.Abstract;
using BookApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.Business.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookManager(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book CreateBook(Book book)
        {
            return _bookRepository.CreateBook(book);
        }

        public void DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
        }

        public List<Book> GetAllBook()
        {
           return _bookRepository.GetAllBook();
        }

        public Book GetBookById(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public Book UpdateBook(Book book)
        {
            return _bookRepository.UpdateBook(book);
        }
    }
}
