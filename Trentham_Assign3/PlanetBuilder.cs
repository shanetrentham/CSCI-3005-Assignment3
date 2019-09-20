using System;
namespace Trentham_Assign3
{
    public class PlanetBuilder : Planet
    {
        private Planet planet;

        public PlanetBuilder()
        {
            planet = null;
        }

        public void BuildPlanet()
        {
            Console.WriteLine("Enter the name of the planet: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the diameter of the planet: ");
            decimal diameter = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the distance of the planet from the sun: ");
            decimal distanceFromSun = decimal.Parse(Console.ReadLine());

            Planet p = new Planet(name, diameter, distanceFromSun);
            planet = p;
        }

        public Planet GetPlanet()
        {
            if (planet == null)
                throw new NullReferenceException("Object has not been built yet.");
            else
                return planet;
        }
    }
}
