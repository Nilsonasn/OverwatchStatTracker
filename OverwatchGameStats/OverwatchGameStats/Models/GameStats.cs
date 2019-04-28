using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchGameStats.Models
{
    public enum CommRating {Toxic, None, Average, Good }
    public enum GameTypeEnum { Quickplay, Competitive}
    public class SingleGameData : Screen
    {
        private Heroes heroes;
        private bool[] communication = new bool[4];
        private bool[] gametype = new bool[2];
        private DateTime gamedate = DateTime.Now;
        private int timeHr;
        private int timeMin;
        public Heroes AllHeroes
        {
            get { return heroes; }
            set { heroes = value; }

        }
        public bool[] Communication {
            get { return communication; }
            set { communication = value; }

        }

        public bool[] GameType
        {
            get { return gametype; }
            set { gametype = value; }
        }

        public SingleGameData()
        {
            AllHeroes = new Heroes();
            communication[1] = true;
            gametype[1] = true;

        }

        public int TimeHr
        {
            get
            {
                return gamedate.Hour;
            }
            set
            {
                gamedate = ChangeTime(gamedate,value, gamedate.Minute);
            }
        }

        public int TimeMin
        {
            get
            {
                return gamedate.Minute;
            }
            set
            {
                gamedate = ChangeTime(gamedate, gamedate.Hour, value);
            }
        }

        public DateTime GameDate{
            get
            {
                return gamedate;
            }
            set
            {
                gamedate = value;
                NotifyOfPropertyChange(() => GameDate);
                NotifyOfPropertyChange(() => TimeHr);
                NotifyOfPropertyChange(() => TimeMin);
            }
        }
        public static DateTime ChangeTime(DateTime dateTime, int hours, int minutes)
        {
            return new DateTime(
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                hours,
                minutes,
                dateTime.Second,
                dateTime.Millisecond,
                dateTime.Kind);
        }
    }
}
