using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchGameStats.Models
{
    public enum MedalRank { NA, None, Bronze, Silver, Gold }
    public class Medal
    {
        MedalRank rank;
        string medaltype;

        public int Rank
        {
            get { return (int)rank; }
            set { rank = (MedalRank)value; }
        }

        public string MedalType
        {
            get { return medaltype; }
            set { medaltype = value; }
        }

        public Medal(string type)
        {
            Rank = 0;
            MedalType = type;
        }
    }
}
