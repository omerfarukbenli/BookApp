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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
                _categoryRepository = categoryRepository;
        }
        public Category CreateCategory(Category category)
        {
            return _categoryRepository.CreateCategory(category);
        }

        public void DeletelCategory(int id)
        {
            _categoryRepository.DeletelCategory(id);
        }

        public List<Category> GetAllCategory()
        {
            return _categoryRepository.GetAllCategory();
        }

        public Category GetCategoryById(int id)
        {
           return _categoryRepository.GetCategoryById(id);
        }

        public Category UpdateCategory(Category category)
        {
            return _categoryRepository.UpdateCategory(category);
        }
    }
}
