using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public class OfferBank
    {
        private OfferBank(OfferBankEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
        }

        protected internal OfferBank() { } //For EF

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public static implicit operator OfferBank(OfferBankEnum @enum) => new OfferBank(@enum);

        public static implicit operator OfferBankEnum(OfferBank enumvar) => (OfferBankEnum)enumvar.Id;
    }
}
