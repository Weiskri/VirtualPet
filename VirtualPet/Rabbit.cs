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
        private bool isSick;
        private bool isDirty;

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

        public bool IsSick
        {
            get { return this.isSick; }
            set { this.isSick = value; }
        }

        public bool IsDirty
        {
            get { return this.isDirty; }
            set { this.isDirty = value; }
        }

        // constructors

        public Rabbit ()
        {
            // default constructor
        }

        public Rabbit (string name, string disposition, bool isThirsty, bool isHungry, bool isSick, bool isDirty)
        {
            this.name = name;
            this.disposition = disposition;
            this.isThirsty = isThirsty;
            this.isHungry = isHungry;
            this.isSick = isSick;
        }

        // methods

        public string CleanCage ()
        {
            if (isDirty == true)
            {
                isDirty = false;
                disposition = "happy";
                return "The cage is clean and your bunny is happy!";
            }
            else 
            {
                return "The cage is still clean!";
            }
        }

        public string Play ()
        {
            disposition = "happy";
            return "Hegel is binkying and is happy!";
        }

        public void RefillFoodAndWater ()
        {
            disposition = "happy";
            isHungry = false;
            isThirsty = false;
        }

        public string TakeToVet ()
        {
            if (isSick == true)
            {
                isSick = false;
                return "Your bunny was very sick, but he's feeling better now.";
            }

            else
            {
                return "Your bunny's checkup went very well.";
            }
        }

        public void Tick ()
        {
            List<string> dispositionList = new List<string>() { "bored", "happy", "unhappy", "angry" };
            Random r = new Random();
            int index = r.Next(dispositionList.Count);
            disposition = dispositionList[index];
            isHungry = true;
            isThirsty = true;
            isSick = false;
            isDirty = true;
        }
    }
}
