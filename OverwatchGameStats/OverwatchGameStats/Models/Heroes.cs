using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchGameStats.Models
{
    public class Heroes
    {
        List<Hero> herolist;
        private Hero ana = new Hero("Ana");
        private Hero ashe = new Hero("Ashe");
        private Hero baptiste = new Hero("Baptsite");
        private Hero bastion = new Hero("Bastion");
        private Hero brigitte = new Hero("Brigitte");
        private Hero dva = new Hero("Dva");
        private Hero doomfist = new Hero("Doomfist");
        private Hero genji = new Hero("Genji");
        private Hero hanzo = new Hero("Hanzo");
        private Hero junkrat = new Hero("Junkrat");
        private Hero lucio = new Hero("Lucio");
        private Hero mccree = new Hero("Mccree");
        private Hero mei = new Hero("Mei");
        private Hero mercy = new Hero("Mercy");
        private Hero moira = new Hero("Moira");
        private Hero orisa = new Hero("Orisa");
        private Hero pharah = new Hero("Pharah");
        private Hero reaper = new Hero("Reaper");
        private Hero reinhardt = new Hero("Reinhardt");
        private Hero roadhog = new Hero("Roadhog");
        private Hero soldier76 = new Hero("Soldier76");
        private Hero sombra = new Hero("Sombra");
        private Hero symmetra = new Hero("Symmetra");
        private Hero torbjorn = new Hero("Torbjorn");
        private Hero tracer = new Hero("Tracer");
        private Hero widowmaker = new Hero("Widowmaker");
        private Hero winston = new Hero("Winston");
        private Hero wreckingball = new Hero("Wreckingball");
        private Hero zarya = new Hero("Zarya");
        private Hero zenyatta = new Hero("Zenyatta");

        public Hero Ana { get { return ana; } }
        public Hero Ashe { get { return ashe; } }
        public Hero Baptiste { get { return baptiste; } }
        public Hero Bastion { get { return bastion; } }
        public Hero Brigitte { get { return brigitte; } }
        public Hero Dva { get { return dva; } }
        public Hero Doomfist { get { return doomfist; } }
        public Hero Genji { get { return genji; } }
        public Hero Hanzo { get { return hanzo; } }
        public Hero Junkrat { get { return junkrat; } }
        public Hero Lucio { get { return lucio; } }
        public Hero Mccree { get { return mccree; } }
        public Hero Mei { get { return mei; } }
        public Hero Mercy { get { return mercy; } }
        public Hero Moira { get { return moira; } }
        public Hero Orisa { get { return orisa; } }
        public Hero Pharah { get { return pharah; } }
        public Hero Reaper { get { return reaper; } }
        public Hero Reinhardt { get { return reinhardt; } }
        public Hero Roadhog { get { return roadhog; } }
        public Hero Soldier76 { get { return soldier76; } }
        public Hero Sombra { get { return sombra; } }
        public Hero Symmetra { get { return symmetra; } }
        public Hero Torbjorn { get { return torbjorn; } }
        public Hero Tracer { get { return tracer; } }
        public Hero Widowmaker { get { return widowmaker; } }
        public Hero Winston { get { return winston; } }
        public Hero Wreckingball { get { return wreckingball; } }
        public Hero Zarya { get { return zarya; } }
        public Hero Zenyatta { get { return zenyatta; } }

        public List<Hero> HeroList
        {
            get { return herolist; }
            set { herolist = value; }
        }


        public Heroes()
        {
            HeroList = new List<Hero>();
            HeroList.Add(ana);
            HeroList.Add(ashe);
            HeroList.Add(baptiste);
            HeroList.Add(bastion);
            HeroList.Add(brigitte);
            HeroList.Add(dva);
            HeroList.Add(doomfist);
            HeroList.Add(genji);
            HeroList.Add(hanzo);
            HeroList.Add(junkrat);
            HeroList.Add(lucio);
            HeroList.Add(mccree);
            HeroList.Add(mei);
            HeroList.Add(mercy);
            HeroList.Add(moira);
            HeroList.Add(orisa);
            HeroList.Add(pharah);
            HeroList.Add(reaper);
            HeroList.Add(reinhardt);
            HeroList.Add(roadhog);
            HeroList.Add(soldier76);
            HeroList.Add(sombra);
            HeroList.Add(symmetra);
            HeroList.Add(torbjorn);
            HeroList.Add(tracer);
            HeroList.Add(widowmaker);
            HeroList.Add(winston);
            HeroList.Add(wreckingball);
            HeroList.Add(zarya);
            HeroList.Add(zenyatta);
        }
    }
    public class Hero
    {
        private string heroname;


        public Hero(string name)
        {
            HeroName = name;
            IsChosen = false;
        }

        public string HeroName
        {
            get { return heroname; }
            set { heroname = value; }
        }

        private bool ischosen;

        public bool IsChosen
        {
            get { return ischosen; }
            set { ischosen = value; }
        }
    }
}
