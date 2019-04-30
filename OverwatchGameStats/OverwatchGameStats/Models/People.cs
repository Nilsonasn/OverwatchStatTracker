using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchGameStats.Models
{
    public class Person
    {
        string name;
        bool isselected;

        public string Name {
            get { return name; }
            set { name = value; }
        }
        public bool IsSelected {
            get { return isselected; }
            set { isselected = value; }
        }
        public Person( string personName)
        {
            Name = personName;
            isselected = false;
        }
    }
}
