using System.Threading;
using Robot;



internal class Program
{
    static void Main(string[] args)
    {
       
        var robot = new GiantKillerRobot();
       // var robotH= new HealerRobot();
        

        List<Lifeform> lifeforms = new List<Lifeform>();
        Dictionary<Planet, int> lifeformCounts = new Dictionary<Planet, int>
        {
            { Planet.Mercury, 10 },
            { Planet.Venus, 15 },
            { Planet.Earth, 20 },
            { Planet.Mars, 5 },
            { Planet.Saturn, 8 },
            { Planet.Jupiter, 12 },
            { Planet.Uranus, 7 },
            { Planet.Neptune, 10 }
        };
        foreach (KeyValuePair<Planet, int> entry in lifeformCounts)
        {
            Planet planet = entry.Key;
            int count = entry.Value;

            for (int i = 0; i < count; i++)
            {
                Lifeform lifeform;

                if (i % 10 == 0)
                {
                    lifeform = new SuperHero(planet);
                }
                else if (i % 5 == 0)
                {
                    lifeform = new Animal(planet);
                }
                else if (i%2==0)
                {
                    lifeform = new Human(planet);
                }
                else
                {
                    lifeform = new Alien(planet);
                }

                lifeforms.Add(lifeform);
            }
        }


       robot.DoWork(Planet.Earth);
       //robotH.DoWork(Planet.Mercury);


    }
}
