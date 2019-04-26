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

        public Heroes AllHeroes
        {
            get { return heroes; }
            set { heroes = value; }
        }

        public SingleGameData()
        {
            AllHeroes = new Heroes();
        }

        
    }
}
