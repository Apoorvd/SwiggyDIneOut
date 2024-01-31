using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataAccess.Contracts
{
    public interface IMenuRepository
    {
        List<Menu> GetAllMenu(int categoryId);
        Menu GetMenuByID(int id);
        Menu GetMenuByName(string name);
        Menu AddMenu(Menu menu);
        Menu UpdateMenu(Menu menu);
        bool DeleteMenu(int id);
    }
}
