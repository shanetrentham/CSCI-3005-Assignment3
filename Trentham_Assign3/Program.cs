/* Shane Trentham
 * CSCI 3005
 * Assignment 3
 * 9/19/2019
 */
using System;
using System.Collections.Generic;

namespace Trentham_Assign3
{
    class MainClass
    {

        /*private static AlphaAlien alphaAlien;
        private static BetaAlien betaAlien;
        private static GammaAlien gammaAlien;
        */
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Spaceship builder!");
            Console.WriteLine("Enter the name of the spaceship: ");
            string name = Console.ReadLine();
            List<Alien> olderThan = new List<Alien>();
            

            Console.WriteLine("Enter the capacity of the spaceship");
            int capacity = int.Parse(Console.ReadLine());

            Spaceship spaceship = new Spaceship(name, capacity);

            int choice = 0;
            //while loop for user interface
            while (choice != 8)
            {
                Console.WriteLine("1. Add an Alien");
                Console.WriteLine("2. Get the number of Aliens in the spaceship");
                Console.WriteLine("3. Find the oldest Alien");
                Console.WriteLine("4. Find the oldest Alien of a color");
                Console.WriteLine("5. Get the count of good Aliens");
                Console.WriteLine("6. Get the count of bad Aliens");
                Console.WriteLine("7. Get Aliens older than a certain age");
                Console.WriteLine("8. Quit");
                choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        {
                            Alien alien = AlienBuilder();
                            spaceship.AddAlien(alien);
                            Console.WriteLine(alien.ToString());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("There are " + spaceship.Count() + " Aliens in the spaceship.");
                            break;
                        }
                    case 3:
                        {
                            Alien oldest = spaceship.getOldest();
                            Console.WriteLine(oldest.ToString());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Get the oldest of species(Alpha, Betta, Gamma): ");
                            string ans = Console.ReadLine();
                            Alien oldestofColor = spaceship.getOldest(ans.ToLower());
                            Console.WriteLine(oldestofColor.ToString());
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("The total number of good Aliens is: " + spaceship.getGood(true));
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("The total number of bad Aliens is: " + spaceship.getGood(false));
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Enter the youngest age for Aliens");
                            int minAge = int.Parse(Console.ReadLine());
                            olderThan = spaceship.isGreaterThan(minAge);
                            foreach(Alien alien in olderThan)
                            {
                                Console.WriteLine(alien.ToString());
                            }
                            break;
                        }
                    case 8:
                        {
                            System.Environment.Exit(0);
                            break;
                        }
                }
            }
        }
        //Builds new aliens using user input
        public static Alien AlienBuilder()
        {
            string name, species, good, input;
            bool isGood = true;
            long age, inAge;
            Alien alien = new Alien();

            Console.WriteLine("Enter the name of the Alien: ");
            input = Console.ReadLine();

            if (input == "")
                throw new Exception("The name must not be empty");
            else
                name = input;

            Console.WriteLine("Enter the sub-species of Alien(Alpha, Beta, or Gamma: ");
            input = Console.ReadLine();

            if (input == "" || input.ToLower() != "alpha" && input.ToLower() != "beta" && input.ToLower() != "gamma")
                throw new Exception("The species must be Alpha, Beta, or Gamma");
            else
                species = input.ToLower();

            Console.WriteLine("Enter the age of the Alien: ");
            inAge = long.Parse(Console.ReadLine());

            if (inAge < 0)
                throw new Exception("Age must not be a negative number");
            else
                age = inAge;

            Console.WriteLine("Is the Alien good or bad? ");
            good = Console.ReadLine();

            if (good.ToLower() == "good")
                isGood = true;
            else if (good.ToLower() == "bad")
                isGood = false;
            if (species.ToLower() == "alpha")
            {
                AlphaAlien alphaAlien = new AlphaAlien(name, age, isGood);
                alien = alphaAlien.GetAlien();
            }
            else if (species.ToLower() == "beta")
            {
                BetaAlien betaAlien = new BetaAlien(name, age, isGood);
                alien = betaAlien.GetAlien();
            }
            else if (species.ToLower() == "gamma")
            {
                GammaAlien gammaAlien = new GammaAlien(name, age, isGood);
                alien = gammaAlien.GetAlien();
            }
            return alien;
        }
    }
}
