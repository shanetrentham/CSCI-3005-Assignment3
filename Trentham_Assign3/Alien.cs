using System;
namespace Trentham_Assign3
{
    public class Alien : Planet
    {
        private string mName;
        private string mColor;
        private long mAge;
        private bool isGood;
        private Planet AlienPlanet;

        public Alien()
        {
            mName = "";
            mColor = "";
            mAge = 0;
            isGood = true;
            AlienPlanet = null;
        }

        public Alien(string name, string color, long age, bool isGood)
        {
            this.mName = name;
            this.mColor = color;
            this.mAge = age;
            this.isGood = isGood;
        }

        public void setName(string name)
        {
            this.mName = name;
        }

        public string GetName()
        {
            return mName;
        }

        public void setColor(string color)
        {
            this.mColor = color;
        }

        public string getColor()
        {
            return mColor;
        }

        public void setAge(long age)
        {
            this.mAge = age;
        }

        public long getAge()
        {
            return mAge;
        }
        public void setIsGood(bool s)
        {
            this.isGood = s;
        }

        public bool getIsGood()
        {
            return isGood;
        }

        public string getGoodOrBad()
        {
            if (isGood == true)
                return "Good";
            else
                return "Bad";
        }

        public void setAlienPlanet(Planet p)
        {
            this.AlienPlanet = p;
        }

        public Planet getAlienPlanet()
        {
            return AlienPlanet;
        }

        public override string ToString()
        {
            return mName + " - " + mColor + " - age: " + mAge + " - " + getGoodOrBad();
        }
    }
}
