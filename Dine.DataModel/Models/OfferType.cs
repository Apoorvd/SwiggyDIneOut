using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public class OfferType
    {
        private OfferType(OfferTypeEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
        }

        protected internal OfferType() { } //For EF

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public static implicit operator OfferType(OfferTypeEnum @enum) => new OfferType(@enum);

        public static implicit operator OfferTypeEnum(OfferType enumvar) => (OfferTypeEnum)enumvar.Id;
    }
}
