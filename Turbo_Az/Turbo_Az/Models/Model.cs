using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo_Az.Models
{
    public class Model
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
    }
}
