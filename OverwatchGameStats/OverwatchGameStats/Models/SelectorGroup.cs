using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchGameStats.Models
{
    public class SelectorGroup
    {
        bool isselected;
        string itemname;

        public string ItemName
        {
            get { return itemname; }
            set { itemname = value; }
        }
        public bool IsSelected
        {
            get { return isselected; }
            set { isselected = value; }
        }
    }
}
