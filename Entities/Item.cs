﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Item
    {
        public GlobalItem Global { get; set; }
        public List<CountryItem> Countries { get; set; }
    }
}
