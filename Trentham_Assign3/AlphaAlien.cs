using System;
namespace Trentham_Assign3
{
    public class AlphaAlien : Alien
    {
        private Alien alien;
        public AlphaAlien(string name, long age, bool isGood)
        {
            alien = new Alien(name, "blue", age, isGood);
        }
        public override string ToString()
        {
            return "Alpha Alien - " + alien.ToString();
        }
        public Alien GetAlien()
        {
            return alien;
        }
    }
}
