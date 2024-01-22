using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public class OrderStatus
    {
        private OrderStatus(OrderStatusEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
        }

        protected internal OrderStatus() { } //For EF

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public static implicit operator OrderStatus(OrderStatusEnum @enum) => new OrderStatus(@enum);

        public static implicit operator OrderStatusEnum(OrderStatus enumvar) => (OrderStatusEnum)enumvar.Id;
    }
}
