using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Robot
{
    public class Planet
    {
        public string Name { get; set; }
        public List<Lifeform> Inhabitants { get; set; }
        public bool ContainsLife
        {
            get
            {
                if (Inhabitants.Count > 0)
                    return true;
                else
                    return false;
            }
        }

        public static Planet Mercury = new Planet("Mercury");
        public static Planet Venus = new Planet("Venus");
        public static Planet Earth = new Planet("Earth");
        public static Planet Mars = new Planet("Mars");
        public static Planet Saturn = new Planet("Saturn");
        public static Planet Jupiter = new Planet("Jupiter");
        public static Planet Uranus = new Planet("Uranus");
        public static Planet Neptune = new Planet("Neptune");
        protected Planet(string name)
        {
            Name = name;
            Inhabitants = new List<Lifeform>();
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
   

