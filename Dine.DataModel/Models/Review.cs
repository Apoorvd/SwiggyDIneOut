using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public class Review // before uploading review, it goes to an AI check if the review is family friendly or not, like endpointing to some python node
    {
        public long Id { get; set; }
        public int RestaurantId { get; set; }
        public int MenuId { get; set; }
        public long UserId { get; set; }
        public string ReviewText { get; set; }
        public string ReviewTitle { get; set;}
        public byte ReviewStar {  get; set; }

    }
}
