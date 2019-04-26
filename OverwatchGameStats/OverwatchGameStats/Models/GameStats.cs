using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchGameStats.Models
{
    public class SingleGameData
    {
        private Heroes heroes;
        private bool[] communication = new bool[4];

        public Heroes AllHeroes
        {
            get { return heroes; }
            set { heroes = value; }
            
        }
        public bool[] Communication{
            get { return communication; }
            set { communication = value; }

        }

        public SingleGameData()
        {
            AllHeroes = new Heroes();

            
        }

        
    }
}
