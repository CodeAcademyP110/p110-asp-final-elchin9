using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo_Az.Models
{
    public class News
    {
        public int Id { get; set; }

        public string PhotoURL { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string MainInfo { get; set; }

        [Required, StringLength(200)]
        public string ShortInfo { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
