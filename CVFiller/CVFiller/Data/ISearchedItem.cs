﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFiller.Data
{
    interface ISearchedItem
    {
        string Key { get; set; }
        string Value { get; set; }
        List<string> Tags { get; set; }
    }
}
