using System;
namespace Trentham_Assign3
{
    public class Planet
    {
        private string name;
        private decimal diameter;
        private decimal distanceFromSun;

        public Planet()
        {

        }

        public Planet(string n, decimal d, decimal dFromSun)
        {

            if (n.Length == 0)
            {
                throw new System.ArgumentException("The name cannot be an empty string.");
            }
            else
                name = n;
            if (d < 0)
            {
                throw new System.ArgumentException("The diameter cannot be negative.");
            }
            else
                diameter = d;
            if (dFromSun < 0)
            {
                throw new System.ArgumentException("The distance cannot be negative.");
            }
            else
                distanceFromSun = dFromSun;
        }

        public Planet(string name)
        {
            this.name = name;
            this.diameter = 0;
            this.distanceFromSun = 0;
        }

        public string getName()
        {
            return name;
        }

        public decimal getDiameter()
        {
            return diameter;
        }

        public decimal getDistanceFromSun()
        {
            return distanceFromSun;
        }

        public decimal computeVolume()
        {
            decimal num = ((decimal)((Math.PI * Math.Pow(((double)(diameter / 2)), 3))));
            return (num * 4) / 3;
        }
    }
}

