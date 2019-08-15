using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo_Az.Models
{
    public class Advertisement
    {
        public int Id { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int ModelId { get; set; }
        public virtual Model Model { get; set; }


        public int ColorId { get; set; }
        public virtual Color Color { get; set; }


        public int FuelId { get; set; }
        public virtual Fuel Fuel { get; set; }


        public int Hiking{ get; set; }


        public int MachinePowerId { get; set; }
        public virtual MachinePower MachinePower { get; set; }


        public int GradiuationYearId { get; set; }
        public virtual GradiuationYear GradiuationYear { get; set; }


        public int SpeedId { get; set; }
        public virtual Speed Speed { get; set; }

        [Required]
        public string CarInfo { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }


        public DateTime AdYear { get; set; }

        public bool IsVip { get; set; }
        public DateTime UpdateYear { get; set; }

        public string PhotoURL { get; set; }

        public virtual ICollection<AdPhotos> Photos { get; set; }
    }
}
