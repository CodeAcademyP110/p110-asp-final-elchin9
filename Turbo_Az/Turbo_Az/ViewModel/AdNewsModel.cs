using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turbo_Az.Models;

namespace Turbo_Az.ViewModel
{
    public class AdNewsModel
    {
        public IEnumerable<Advertisement> Advertisements { get; set; }
        public IEnumerable<News> News { get; set; }
    }
}
