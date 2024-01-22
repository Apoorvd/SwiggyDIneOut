using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dine.DataModel.Models
{
    public class ReservationStatus
    {
        private ReservationStatus(ReservationStatusEnum @enum)
        {
            Id = (int)@enum;
            Name = @enum.ToString();
        }

        protected internal ReservationStatus() { } //For EF

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public static implicit operator ReservationStatus(ReservationStatusEnum @enum) => new ReservationStatus(@enum);

        public static implicit operator ReservationStatusEnum(ReservationStatus enumvar) => (ReservationStatusEnum)enumvar.Id;
    }
}
