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
                return "The cage is clean!";
            }
            else 
            {
                return "The cage is still clean!";
            }
        }

        public string Play ()
        {
            return "Hegel is binkying!";
        }

        public string RefillFood()
        {
            List<string> foodList = new List<string>() { "cilantro", "timothy hay", "kale", "banana" };
            Random r = new Random();
            int foodIndex = r.Next(foodList.Count);
            string food = foodList[foodIndex];
            if (isSick == true)
            {
                return "Hegel won't eat because he's sick.";
            }
            else if ((food == "timothy hay") || (food == "banana")) {
                isHungry = false;
                isThirsty = true;
                return "Hegel ate the " + foodList[foodIndex] + ".";
            }
            else
            {
                return "Hegel refused the " + foodList[foodIndex] + ".";
            }
        }
        
        public void RefillWater()
        {
            if (isSick == true)
            {
                Console.WriteLine("Hegel won't drink because he's sick.");
            }
            else
            {
                Console.WriteLine("Hegel is drinking some water.");
                isThirsty = false;
            }
            
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

        public string DispositionDetermination() {

                    
            if ((isDirty == true) && ((isSick == true)))
            {
                disposition = "angry";
                return "angry";
            }
            else if ((isDirty == false) && ((isHungry == false) && (isThirsty == false)))
            {
                disposition = "happy";
                return "happy";
            }
            else 
            {
                disposition = "grumpy";
                return "grumpy";
            }
        }

        public void Tick ()
        {
            // Some of these values are random when the user opens the app, others are not.
            Random r = new Random();
            List<bool> boolList = new List<bool>() { true, false };
            int dirtyIndex = r.Next(boolList.Count);
            isDirty = boolList[dirtyIndex];
            int hungryIndex = r.Next(boolList.Count);
            isHungry = boolList[hungryIndex];
            int thirstyIndex = r.Next(boolList.Count);
            isThirsty = boolList[thirstyIndex];
            if ((isDirty == true) && ((isHungry == true)))
            {
                isSick = true;
            }
            else
            {
                isSick = false;
            }

            // initial disposition

            if ((isDirty == true) && ((isSick == true)))
            {
                disposition = "angry";
            }
            else if ((isDirty == false) && ((isHungry == false) && (isThirsty == false)))
            {
                disposition = "happy";
            }
            else
            {
                disposition = "grumpy";
            }

        }
    }
}
