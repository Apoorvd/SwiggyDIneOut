using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataAccess.Contracts
{
    public interface ICategoryMenuRepository
    {
        List<CategoryMenu> GetCategories(int RestaurantId);
        CategoryMenu GetCategory(int CategoryId);
        bool AddCategory(CategoryMenu categoryMenu);
        bool DeleteCategory(int CategoryId);
        bool UpdateCategory(CategoryMenu categoryMenu);
    }
}
