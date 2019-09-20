using System;
using System.Collections.Generic;
namespace Trentham_Assign3
{
    public class Spaceship : Alien
    {
        private int maxCapacity;
        private List<Alien> lst = new List<Alien>();
        private string mName;
        private int count;

        public Spaceship(string name, int capacity)
        {
            this.mName = name;
            this.maxCapacity = capacity;
        }

        public void AddAlien(Alien alien)
        {
            //Console.WriteLine(alien.ToString());
            if (lst.Count == maxCapacity)
            {
                throw new System.ApplicationException("The space ship is full!");
            }
            else
                this.lst.Add(alien);
        }

        public int Count()
        {
            return lst.Count;
        }

        public Alien getOldest()
        {
            return getOldest("all");
        }

        public Alien getOldest(string color)
        {
            Alien oldest = new Alien();
            if (color == "all")
            {
                foreach (Alien i in lst)
                {
                    if (i.getAge() > oldest.getAge())
                    {
                        oldest = i;
                    }


                }
            }
            else
                foreach (Alien i in lst)
                {
                    if (i.getColor() == color.ToLower())
                    {
                        if (i.getAge() > oldest.getAge())
                        {
                            oldest = i;

                        }
                    }
                }
            if (oldest.GetName() == "")
                throw new Exception("No Alien of that type exists");
            else
                return oldest;
        }

        public int getGood(Boolean type)
        {
            int total = 0;
            foreach (Alien i in lst)
            {
                if (i.getIsGood() == type)
                    total++;
            }
            return total;
        }

        public List<Alien> isGreaterThan(int age)
        {
            List<Alien> aliens = new List<Alien>();

            foreach (Alien alien in lst)
            {
                if (alien.getAge() >= age)
                    aliens.Add(alien);
            }
            return aliens;
        }

        public override string ToString()
        {
            string s = "";
            foreach (Alien alien in lst)
            {
                //mName + " - " + mColor + " - age: " + mAge + " - " + isGood + " - " + AlienPlanet.getName();
                s = alien.GetName() + " - " + alien.getColor() + " - age: " + alien.getAge() + " - " + alien.getGoodOrBad() + " - " + alien.getAlienPlanet() + "\n";
            }
            return s;
        }

    }
}
