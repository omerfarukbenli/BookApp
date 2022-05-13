using BookApp.Business.Abstract;
using BookApp.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet]
        public List<Book> Get()
        {
            return _bookService.GetAllBook();
        }
       [HttpGet("{id}")]
       public Book Get(int id)
        {
            return _bookService.GetBookById(id);
        }
        [HttpPost]
        public Book Post([FromBody]Book book)
        { 
            return _bookService.CreateBook(book);      
        }
        [HttpPut]
        public Book Put ([FromBody]Book book)
        {
            return _bookService.UpdateBook(book);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bookService.DeleteBook(id);
        }

    }
}
