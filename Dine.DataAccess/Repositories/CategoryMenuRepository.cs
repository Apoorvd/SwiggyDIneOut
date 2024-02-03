using Dine.DataAccess.Contracts;
using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataAccess.Repositories
{
    public class CategoryMenuRepository : ICategoryMenuRepository
    {
        public bool AddCategory(CategoryMenu categoryMenu)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategory(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public List<CategoryMenu> GetCategories(int RestaurantId)
        {
            throw new NotImplementedException();
        }

        public CategoryMenu GetCategory(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCategory(CategoryMenu categoryMenu)
        {
            throw new NotImplementedException();
        }
    }
}
