using BookApp.DataAccess.Abstract;
using BookApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DataAccess.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;
        public CategoryRepository(DataContext context)
        {
            _context = context;
        }
        public Category CreateCategory(Category category)
        {
           _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public void DeletelCategory(int id)
        {
            var deleteCategory = GetCategoryById(id);
            _context.Categories.Remove(deleteCategory);
            _context.SaveChanges();
        }

        public List<Category> GetAllCategory()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }

        public Category UpdateCategory(Category category)
        {
           _context.Categories.Update(category);
            _context.SaveChanges();
            return category;
        }
    }
}
