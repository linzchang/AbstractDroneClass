using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDroneClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*I used SOLID principles by using an abstract class, this helps with the open/closed principal
             * Also by overriding method in Quadrotor class, the method in abstract class is more general
             */

            QuadrotorDrone drone = new QuadrotorDrone();
            int speed = drone.FlightSpeed();
            Console.WriteLine(speed);
            Console.ReadLine();
        }
    }
}
