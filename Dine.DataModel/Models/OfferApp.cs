using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public class OfferApp
    {
        private OfferApp(OfferAppEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
        }

        protected internal OfferApp() { } //For EF

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public static implicit operator OfferApp(OfferAppEnum @enum) => new OfferApp(@enum);

        public static implicit operator OfferAppEnum(OfferApp enumvar) => (OfferAppEnum)enumvar.Id;
    }
}
