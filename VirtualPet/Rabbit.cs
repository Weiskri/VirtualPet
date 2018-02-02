using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Rabbit
    {
        // fields

        private string name;
        private string disposition;
        private bool isThirsty;
        private bool isHungry;
        private int boredomLevel;
        private bool isSick;

        // properties

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Disposition
        {
            get { return this.disposition; }
            set { this.disposition = value; }
        }

        public bool IsThirsty
        {
            get { return this.isThirsty; }
            set { this.isThirsty = value; }
        }
        
        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

        public int BoredomLevel
        {
            get { return this.boredomLevel; }
            set { this.boredomLevel = value; }
        }

        public bool IsSick
        {
            get { return this.isSick; }
            set { this.isSick = value; }
        }

        // constructors

        public Rabbit ()
        {
            // default constructor
        }

        public Rabbit (string name, string disposition, bool isThirsty, bool isHungry, int boredomLevel, bool isSick)
        {
            this.name = name;
            this.disposition = disposition;
            this.isThirsty = isThirsty;
            this.isHungry = isHungry;
            this.boredomLevel = boredomLevel;
            this.isSick = isSick;
        }
    }
}
