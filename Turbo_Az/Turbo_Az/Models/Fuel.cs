using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo_Az.Models
{
    public class Fuel
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string CarFuel { get; set; }

        public virtual ICollection<Advertisement> Advertisement { get; set; }
    }
}
