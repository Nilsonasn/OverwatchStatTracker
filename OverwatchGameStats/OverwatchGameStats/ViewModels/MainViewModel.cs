using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using OverwatchGameStats.Models;
using OverwatchGameStats.Views;
using System.Windows.Data;
using System.Windows;

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
        public Map SelectedMapType
        {
            get { return _seletedMapType; }
            set { _seletedMapType = value;
                NotifyOfPropertyChange(() => SelectedMapType);
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

        public void Submit()
        {
            String Header = "Date,Time,MapType,Map,Heroes,Communication,GameType,StackSize,TeamMembers,MedalElims,MedalObjKill,MedalObjTime,MedalHeroDamage,MedalHealing,SR,Outcome,";
            String DataLine = "";
            //Date
            DataLine += GameData.GameDate.ToString("yyyy-MM-dd");
            DataLine += ",";

            //Time
            DataLine += GameData.TimeHr + ":" + GameData.TimeMin;
            DataLine += ",";
            //MapType
            if (SelectedMapType != null)
            {
                DataLine += SelectedMapType.TypeName;
                DataLine += ",";
                //Map
                if (GameData.SelectedMap != null)
                {
                    DataLine += GameData.SelectedMap;
                }
                else
                {
                    DataLine += "NA";
                }
            }
            else
            {
                //MapType
                DataLine += "NA";
                DataLine += ",";
                //Map
                DataLine += "NA";
            }
            DataLine += ",";
            
            
            //Heroes
            //add opening quote
            DataLine += "\"";
            String ChosenHeroes = "";
            foreach (Hero hero in GameData.AllHeroes.HeroList)
            {
                if (hero.IsChosen == true)
                {
                    ChosenHeroes += hero.HeroName + ",";
                }
            }
            //remove trailing comma
            if (ChosenHeroes.Length > 1)
            {
                ChosenHeroes = ChosenHeroes.Substring(0, ChosenHeroes.Length - 1);

                DataLine += ChosenHeroes;
            }
            //closing quote and comma
            DataLine += "\",";

            //Communication
            for(int i = 0; i < GameData.Communication.Length; i++)
            {
                if (GameData.Communication[i] == true)
                {
                    DataLine += ((CommRating)i).ToString();
                }
            }
            DataLine += ",";

            //GameType
            for (int i = 0; i < GameData.GameType.Length; i++)
            {
                if (GameData.GameType[i] == true)
                {
                    DataLine += ((GameTypeEnum)i).ToString();
                }
            }
            DataLine += ",";

            //StackSize
            for(int i = 0; i < GameData.StackSize.Count; i++)
            {
                if(GameData.StackSize[i].IsSelected == true)
                {
                    DataLine += i.ToString();
                }
            }
            DataLine += ",";

            //Team Members
            //add opening quote
            DataLine += "\"";
            String TeamMembers = "";
            foreach (Person pp in GameData.People)
            {
                if (pp.IsSelected == true)
                {
                    TeamMembers += pp.Name + ",";
                }
            }
            //remove trailing comma
            TeamMembers += GameData.OtherPeople;
            //remove trailing comma if necessary
            if (TeamMembers.Length>0 && TeamMembers[TeamMembers.Length - 1] == ',')
            {
                TeamMembers = TeamMembers.Substring(0, TeamMembers.Length - 1);
            }
            DataLine += TeamMembers;
            //closing quote and comma
            DataLine += "\",";

            //Medals
            for (int i = 0; i < GameData.MedalsReceived.Count; i++)
            {
                DataLine += ((MedalRank)GameData.MedalsReceived[i].Rank).ToString();
                DataLine += ",";
            }


            //Game SR
            DataLine += (GameData.SkillRating).ToString();
            DataLine += ",";

            //GameOutcome
            DataLine += (GameData.GameOutcome).ToString();
            DataLine += ",";

            string fPath = @"C:\Users\mrand\Documents\KILL ME\OverwatchStatTracker\Data";
            if (!File.Exists(fPath))
            {
                try
                {
                    StreamWriter file = File.AppendText(fPath);
                    file.WriteLine(Header);
                    file.WriteLine(DataLine);
                    file.Close();
                    MessageBox.Show("Successfully added to datafile.", "Success");
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString(), "Error");
                }
                
            }
            else
            {
                try
                { 
                    StreamWriter file = File.AppendText(fPath);
                    file.WriteLine(DataLine);
                    file.Close();
                    MessageBox.Show("Successfully added to datafile.", "Success");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "Error");
                }
        }
            
        }
    }
}
