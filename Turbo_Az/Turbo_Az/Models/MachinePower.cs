using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo_Az.Models
{
    public class MachinePower
    {
        public int Id { get; set; }

        [Required]
        public int Power { get; set; }

        public virtual ICollection<Advertisement> Advertisement { get; set; }
    }
}
