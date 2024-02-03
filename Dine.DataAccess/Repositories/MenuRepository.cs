using Dine.DataAccess.Contracts;
using Dine.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataAccess.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        public Menu AddMenu(Menu menu)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMenu(int id)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetAllMenu(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Menu GetMenuByID(int id)
        {
            throw new NotImplementedException();
        }

        public Menu GetMenuByName(string name)
        {
            throw new NotImplementedException();
        }

        public Menu UpdateMenu(Menu menu)
        {
            throw new NotImplementedException();
        }
    }
}
