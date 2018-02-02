﻿using System;
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
            Console.WriteLine(" ");
            Console.WriteLine(" /) /)");
            Console.WriteLine(" (^.^)");
            Console.WriteLine(" (\")(\")");
            Console.WriteLine(" ");
            Console.WriteLine("Your rabbit, Hegel, is anxious to interact with you!");

            // interactive menu
            do {
                
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("To check on the status of Hegel, enter 1.");
                Console.WriteLine("To give Hegel some food, enter 2.");
                Console.WriteLine("To refill Hegel's water, enter 3.");
                Console.WriteLine("To clean Hegel's cage, enter 4.");
                Console.WriteLine("To play with Hegel, enter 5.");
                Console.WriteLine("To take Hegel to the vet, enter 6.");
                Console.WriteLine("To exit, enter 7.");
                userChoice = int.Parse(Console.ReadLine());

                // user actions

                switch (userChoice)
                {
                    case 1: // displays the status of the bunny
                        Console.WriteLine("Hegel is " + hegelRabbit.Disposition+ ".");
                        Console.WriteLine("It is " + hegelRabbit.IsHungry + " that Hegel is hungry.");
                        Console.WriteLine("It is " + hegelRabbit.IsThirsty + " that Hegel is thirsty.");
                        Console.WriteLine("It is " + hegelRabbit.IsDirty + " that Hegel's cage needs to be cleaned.");
                        Console.WriteLine("It is " + hegelRabbit.IsSick + " that Hegel needs to go to the vet.");
                        break;
                    case 2: 
                        hegelRabbit.RefillFood();
                        hegelRabbit.DispositionDetermination();
                        Console.WriteLine("Hegel is now happily munching on some fresh hay.");
                        break;
                    case 3:
                        hegelRabbit.RefillWater();
                        hegelRabbit.DispositionDetermination();
                        Console.WriteLine("You refilled Hegel's water.");
                        break;
                    case 4:
                        Console.WriteLine(hegelRabbit.CleanCage());
                        hegelRabbit.DispositionDetermination();
                        break;
                    case 5:
                        hegelRabbit.DispositionDetermination();
                        Console.WriteLine(hegelRabbit.Play());
                        break;
                    case 6:
                        hegelRabbit.DispositionDetermination();
                        Console.WriteLine(hegelRabbit.TakeToVet());
                        break;
                }

            } while (userChoice != 7);
            
        }
    }
}
