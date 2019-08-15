using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo_Az.Models
{
    public class Color
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string CarColor { get; set; }

        public virtual ICollection<Advertisement> Advertisement { get; set; }
    }
}
