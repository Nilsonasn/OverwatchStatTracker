using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace OverwatchGameStats.Models
{
    public enum CommRating {Toxic, None, Average, Good }
    public enum GameTypeEnum { Quickplay, Competitive}
    
    public class SingleGameData : Screen
    {
        private Heroes heroes;
        private bool[] communication = new bool[4];
        private bool[] gametype = new bool[2];
        BindableCollection<SelectorGroup> stacksize;
        private DateTime gamedate = DateTime.Now;
        string otherPeople;
        private BindableCollection<Medal> medalsreceived;
        private int timeHr;
        private int timeMin;
        private int skillrating;
        private bool gameoutcome;
        private BindableCollection<Person> people;
        private string selectedmap;

        public Heroes AllHeroes
        {
            get { return heroes; }
            set { heroes = value; }

        }
        public bool[] Communication {
            get { return communication; }
            set { communication = value; }

        }

        public bool GameOutcome
        {
            get { return gameoutcome; }
            set { gameoutcome = value; }
        }

        public BindableCollection<Medal> MedalsReceived
        {
            get { return medalsreceived; }
            set { medalsreceived = value; }
        }

        public bool[] GameType
        {
            get { return gametype; }
            set { gametype = value; }
        }

        public string SelectedMap
        {
            get { return selectedmap; }
            set { selectedmap = value; }
        }

        public SingleGameData()
        {
            AllHeroes = new Heroes();
            communication[1] = true;
            gametype[1] = true;
            StackSize = new BindableCollection<SelectorGroup>();
            People = new BindableCollection<Person>();
            MedalsReceived = new BindableCollection<Medal>();
            People.Add(new Person("Bryce"));
            People.Add(new Person("Trevor"));
            People.Add(new Person("Spencer"));
            People.Add(new Person("Indiigo"));
            People.Add(new Person("Kr0nai"));
            People.Add(new Person("WhiteRice"));

            StackSize.Add(new SelectorGroup());
            StackSize.Add(new SelectorGroup());
            StackSize.Add(new SelectorGroup());
            StackSize.Add(new SelectorGroup());
            StackSize.Add(new SelectorGroup());
            StackSize.Add(new SelectorGroup());

            MedalsReceived.Add(new Medal("Eliminations"));
            MedalsReceived.Add(new Medal("Objective Kills"));
            MedalsReceived.Add(new Medal("Objective Time"));
            MedalsReceived.Add(new Medal("Hero Damage Done"));
            MedalsReceived.Add(new Medal("Healing Done"));

        }

        public string OtherPeople
        {
            get { return otherPeople; }
            set { otherPeople = value; }
        }

        public BindableCollection<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        public BindableCollection<SelectorGroup> StackSize
        {
            get { return stacksize; }
            set { stacksize = value; }
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

        public int SkillRating
        {
            get { return skillrating; }
            set { skillrating = value; }
        }
        public string SkillRatingStr
        {
            get { return skillrating.ToString(); }
            set { int.TryParse(value,out skillrating); }
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
