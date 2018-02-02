using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit hegelRabbit = new Rabbit("Hegel", "happy", true, true, true, true); // creating new object
            hegelRabbit.Tick();
            int userChoice = 0; // this variable stores the user choice for the menu

            // illness allocation (if Hegel is ill)
            Random r = new Random();
            List<string> illnessList = new List<string>() { " GI stasis ", " the snuffles ", " overgrown teeth " };
            int index = r.Next(illnessList.Count);
            string illness = illnessList[index];

            // initial greeting message (does not repeat)
            Console.WriteLine("Hello, welcome to the virtual pet program.");

            Console.WriteLine("Your rabbit, Hegel, wants to interact with you!");

            // interactive menu
            do {
                Console.WriteLine(" ");
                Console.WriteLine(" /) /)");
                Console.WriteLine(" =(^.^)=");
                Console.WriteLine(" ((\")(\")");
                Console.WriteLine(" ");
                Console.WriteLine("Hegel is " + hegelRabbit.Disposition + ".");
                if (hegelRabbit.IsHungry == true)
                {
                    Console.WriteLine("Hegel is hungry.");
                }
                else
                {
                    Console.WriteLine("Hegel is not hungry.");
                }
                if (hegelRabbit.IsThirsty == true)
                {
                    Console.WriteLine("Hegel is thirsty.");
                }
                else
                {
                    Console.WriteLine("Hegel is not thirsty.");
                }
                if (hegelRabbit.IsDirty == true)
                {
                    Console.WriteLine("Hegel is living in filth! He needs his cage cleaned.");
                }
                else
                {
                    Console.WriteLine("Hegel's cage is neat and tidy.");
                }
                if (hegelRabbit.IsSick == true)
                {
                    Console.WriteLine("Hegel has" + illness + "and needs to go to the vet!");
                }
                else
                {
                    Console.WriteLine("Hegel is healthy.");
                }
                Console.WriteLine();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("To give Hegel some food, enter 1.");
                Console.WriteLine("To refill Hegel's water, enter 2.");
                Console.WriteLine("To clean Hegel's cage, enter 3.");
                Console.WriteLine("To play with Hegel, enter 4.");
                Console.WriteLine("To take Hegel to the vet, enter 5.");
                Console.WriteLine("To exit, enter 6.");
                userChoice = int.Parse(Console.ReadLine());

                // user actions

                switch (userChoice)
                {
                       
                    case 1: 
                        Console.WriteLine(hegelRabbit.RefillFood());
                        hegelRabbit.DispositionDetermination();
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        hegelRabbit.RefillWater();
                        hegelRabbit.DispositionDetermination();
                        Console.WriteLine("You refilled Hegel's water.");
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine(hegelRabbit.CleanCage());
                        hegelRabbit.DispositionDetermination();
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        hegelRabbit.DispositionDetermination();
                        Console.WriteLine(hegelRabbit.Play());
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        hegelRabbit.DispositionDetermination();
                        Console.WriteLine(hegelRabbit.TakeToVet());
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
                

            } while (userChoice != 6);
            Console.WriteLine("Hegel is sad that you don't want to play with him anymore.");

        }
    }
}
