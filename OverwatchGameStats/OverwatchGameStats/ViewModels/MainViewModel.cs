using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OverwatchGameStats.Models;
using OverwatchGameStats.Views;

namespace OverwatchGameStats.ViewModels
{
    class MainViewModel : Screen
    {
        private BindableCollection<Map> maps;
        private Map _seletedMapType;
        private SingleGameData gamedata;
        private bool usecurrenttime = true;

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

        public bool UseCurrentTime {
            get { return usecurrenttime; }
            set { usecurrenttime = value; }
        }

        public void CurrentTime()
        {
            if (UseCurrentTime == true)
            {
                GameData.GameDate = DateTime.Now;
            }
            
            NotifyOfPropertyChange(() => GameData.GameDate);
        }
    }
}
