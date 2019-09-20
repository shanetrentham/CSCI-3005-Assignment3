using System;
namespace Trentham_Assign3
{
    public class BetaAlien
    {
        private Alien alien;
        public BetaAlien(string name, long age, bool isGood)
        {
            alien = new Alien(name, "red", age, isGood);
        }
        public override string ToString()
        {
            return "Beta Alien - " + alien.ToString();
        }
        public Alien GetAlien()
        {
            return alien;
        }
    }
}
