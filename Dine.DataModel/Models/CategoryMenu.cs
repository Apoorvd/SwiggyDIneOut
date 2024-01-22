using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public class CategoryMenu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public ICollection<Menu> Menus { get; set; } // create a one to many relationship with Menu model
        public int RestaurantId { get; set; }
        

    }
}
