using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    
    public abstract class Lifeform
    {

        

        public Planet Inhabits { get; set; }
        public bool IsAlive { get; set; }
       
        double _hp;
        public double HP { get { return _hp; } set { _hp = value; HPCheck(); } }
        void HPCheck()
        {
            if (HP <= 0)
            {
                IsAlive = false;
                Inhabits.Inhabitants.Remove(this);
            }
        }

    }
    
    public class Animal : Lifeform
    {
        public Animal(Planet p)
        {
            Random rnd = new Random();
            Inhabits = p;
            p.Inhabitants.Add(this);
            IsAlive = true;
            HP = rnd.Next(20, 70);
        }
        public override string ToString()
        {
            return "Animal";
        }
    }
    public class Human : Lifeform
    {
        Random rnd = new Random();
        public Human(Planet p)
        {
            Inhabits = p;
            p.Inhabitants.Add(this);
            IsAlive = true;
            HP = rnd.Next(100, 250);

        }
        
        public override string ToString()
        {
            return "Human";
        }
    }
    public class Alien : Lifeform
    {
        Random rnd = new Random();
        public Alien(Planet p)
        {
            Inhabits = p;
            p.Inhabitants.Add(this);
            HP = rnd.Next(200, 400);
        }
        public override string ToString()
        {
            return "Alien";
        }
    }

    public class SuperHero : Lifeform
    {
        Random rnd = new Random();
        public SuperHero(Planet p)
        {
           
            Inhabits = p;
            p.Inhabitants.Add(this);
            IsAlive = true;
            HP = rnd.Next(800,1000);
        }
        public override string ToString()
        {
            return "Superhero";
        }
    }
}
