using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public class UserType
    {
        private UserType(UserTypeEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
        }

        protected internal UserType() { } //For EF

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public static implicit operator UserType(UserTypeEnum @enum) => new UserType(@enum);

        public static implicit operator UserTypeEnum(UserType enumvar) => (UserTypeEnum)enumvar.Id;
    }
}
