using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchGameStats.Models
{
    public enum MapType{Assault,Control,Hybrid,Escort};

    public class Map
    {
        MapType maptype;
        BindableCollection<string> maps;
        public Map(MapType type)
        {
            maps = new BindableCollection<string>();
            maptype = type;
            if(maptype == MapType.Assault)
            {
                maps.Add("Hanamura");
                maps.Add("Horizon Lunar Colony");
                maps.Add("Paris");
                maps.Add("Temple of Anubis");
                maps.Add("Volskaya Industries");
            }
            if (maptype == MapType.Escort)
            {
                maps.Add("Dorado");
                maps.Add("Havana");
                maps.Add("Junkertown");
                maps.Add("Rialto");
                maps.Add("Route 66");
                maps.Add("Watchpoint: Gibraltar");
            }
            if (maptype == MapType.Control)
            {
                maps.Add("Busan");
                maps.Add("Ilios");
                maps.Add("Lijiang Tower");
                maps.Add("Nepal");
                maps.Add("Oasis");
            }
            if (maptype == MapType.Hybrid)
            {
                maps.Add("Blizzard World");
                maps.Add("Eichenwalde");
                maps.Add("Hollywood");
                maps.Add("King's Row");
                maps.Add("Numbani");
            }
        }
        public string TypeName
        {
            get { return maptype.ToString(); }
        }
        public BindableCollection<string> Maps
        {
            get { return maps; }
        }
    }
}
