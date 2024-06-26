using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Robot
{
    public abstract class Robot
    {
        public bool IsRunning { get; set; }
       public abstract Planet TargetPlanet { get; protected set; }
        public abstract void DoWork(Planet target);
    }
    public class GiantKillerRobot : Robot
    {
        public Intensity LaserEyeIntensity { get; private set; }
        public Lifeform CurrentTarget { get; private set; }
        public override Planet TargetPlanet { get; protected set; }

        public GiantKillerRobot()
        {
            IsRunning = false;
            LaserEyeIntensity = Intensity.Shot;
        }
        public override void DoWork(Planet t)
        {
           
            IsRunning = true;


            TargetPlanet =  t;
            while (IsRunning && TargetPlanet.ContainsLife)
            {
                if (CurrentTarget == null || !CurrentTarget.IsAlive)
                {
                    AquireNextTarget();
                }
                else
                {
                    FireLaserAt(CurrentTarget);
                }
              
            }
          
            Console.WriteLine(this.ToString() + " finished his mission.");
        }
        void AquireNextTarget()
        {
            foreach (var target in TargetPlanet.Inhabitants)
            {
                if (target.IsAlive)
                {
                    CurrentTarget = target;
                    Console.WriteLine(this.ToString() + " targets " + target.ToString());
                    break;
                }
            }
            if (!CurrentTarget.IsAlive || CurrentTarget == null)
            {
                this.IsRunning = false;
            }
        }
        void FireLaserAt(Lifeform target)
        {
            target.HP -= LaserEyeIntensity.Damage;
            if (target.IsAlive)
            {
                Console.WriteLine(this.ToString() + " damages " + target.ToString() + " with " + LaserEyeIntensity.Damage.ToString() + " damage." + " Remaining HP: " + target.HP.ToString());
            }
            else
            {
                Console.WriteLine(this.ToString() + " destroys " + target.ToString());
            }

        }
        public override string ToString()
        {
            return "GiantKillerRobot";
        }
    }

   /* public class HealerRobot : Robot
    {
        public Lifeform CurrentTarget { get; private set; }
        public override Planet TargetPlanet { get; protected set; }

        int HealingPower;
        public HealerRobot() 
        {
            IsRunning = false;
           
          
        }
        
        public override void DoWork (Planet t)
        {
            IsRunning = true;
            TargetPlanet = t;
            while (IsRunning && TargetPlanet.ContainsLife)
            {
                if ( CurrentTarget.IsAlive)
                {
                    HealingPower += 100;
                }
                
            }
               

            }*/
        }
    
    





