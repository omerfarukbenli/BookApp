using BookApp.Business.Abstract;
using BookApp.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public List<Category> Get()
        {
            return _categoryService.GetAllCategory();
        }
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _categoryService.GetCategoryById(id);
        }
        [HttpPost]
        public Category Post([FromBody]Category category)
        {
            return _categoryService.CreateCategory(category);
        }
          [HttpPut]
          public Category Put ([FromBody]Category category)
        {
            return _categoryService.UpdateCategory(category);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _categoryService.DeletelCategory(id);
        }
    }
}
