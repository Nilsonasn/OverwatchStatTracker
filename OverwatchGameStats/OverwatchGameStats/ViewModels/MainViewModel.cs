using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OverwatchGameStats.Models;

namespace OverwatchGameStats.ViewModels
{
    class MainViewModel : Screen
    {
        private BindableCollection<Map> maps;
        private Map _seletedMapType;
        private SingleGameData gamedata;

        public MainViewModel()
        {
            maps = new BindableCollection<Map>();
            maps.Add(new Map(MapType.Assault));
            maps.Add(new Map(MapType.Control));
            maps.Add(new Map(MapType.Escort));
            maps.Add(new Map(MapType.Hybrid));
            gamedata = new SingleGameData();
        }

        public BindableCollection<Map> MapList
        {
            get { return maps; }
        }
        public Map SelectedMap
        {
            get { return _seletedMapType; }
            set { _seletedMapType = value;
                NotifyOfPropertyChange(() => SelectedMap);
            }
        }
        public SingleGameData GameData{ get { return gamedata; } }

    }
}
