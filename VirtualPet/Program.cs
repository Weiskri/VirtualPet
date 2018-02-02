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
            Rabbit hegelRabbit = new Rabbit("Hegel", "happy", true, true, true, true);
            hegelRabbit.Tick();
            int userChoice = 0;

            Console.WriteLine("Hello, welcome to the virtual pet program.");

            Console.WriteLine("Your rabbit, Hegel, is anxious to interact with you!");

            // interactive menu
            do {
                Console.WriteLine(" ");
                Console.WriteLine(" /) /)");
                Console.WriteLine(" =(^.^)=");
                Console.WriteLine(" ((\")(\")");
                Console.WriteLine(" ");
                Console.WriteLine("Hegel is " + hegelRabbit.Disposition + ".");
                Console.WriteLine("It is " + hegelRabbit.IsHungry + " that Hegel is hungry.");
                Console.WriteLine("It is " + hegelRabbit.IsThirsty + " that Hegel is thirsty.");
                Console.WriteLine("It is " + hegelRabbit.IsDirty + " that Hegel's cage needs to be cleaned.");
                Console.WriteLine("It is " + hegelRabbit.IsSick + " that Hegel needs to go to the vet.");
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
                        hegelRabbit.RefillFood();
                        hegelRabbit.DispositionDetermination();
                        Console.WriteLine("Hegel is now happily munching on some fresh hay.");
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
