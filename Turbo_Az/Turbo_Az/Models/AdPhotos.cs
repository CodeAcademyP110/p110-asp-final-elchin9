using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo_Az.Models
{
    public class AdPhotos
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string PhotoURL { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }


        public int AdvertisementId { get; set; }
        public virtual Advertisement Advertisement { get; set; }
    }
}
