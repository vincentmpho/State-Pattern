using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>Automated car driving>>>>>");

            Console.WriteLine("Enter car speed ");
            int speed = Convert.ToInt32(Console.ReadLine());
            Car.State s = state.P;
            Car.Gear g = gear.First;
            if (speed == 0)
            {
                s = Car.State.N;
            }

            if (speed < 20)
            {
                s = Car.State.D;
                g = Car.Gear.First;
            }

            if (speed > 20 && speed < 40)
            {
                s = Car.State.D;
                g = Car.Gear.Second;
            }

            if (speed > 40 && speed < 60)
            {
                s = Car.State.D;
                g = Car.Gear.Third;
            }
            if (speed > 60)
            {
                s = Car.State.D;
                g = Car.Gear.Fourth;
            }


            Console.WriteLine("State of car is " + s);
            Console.WriteLine("State of car is " + g);

        }


    }
}
}
