using System;
namespace Trentham_Assign3
{
    public class GammaAlien
    {
        private Alien alien;
        public GammaAlien(string name, long age, bool isGood)
        {
            alien = new Alien(name, "green", age, isGood);
        }
        public override string ToString()
        {
            return "Gamma Alien" + alien.ToString();
        }
        public Alien GetAlien()
        {
            return alien;
        }
    }
}