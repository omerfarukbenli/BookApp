using BookApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp.DataAccess.Abstract
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategory();

        Category GetCategoryById(int id);

        Category CreateCategory(Category category);

        Category UpdateCategory(Category category);

        void DeletelCategory(int id);
    }
}
