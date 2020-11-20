using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class CountryItem:GlobalItem
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Slug { get; set; }

        public string date { get; set; }
    }
}
