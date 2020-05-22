using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFiller.Data
{
    public class SearchedItem : ISearchedItem
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public List<string> Tags { get; set; }
    }
}
