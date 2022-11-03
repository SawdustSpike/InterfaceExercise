using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public SUV()
        {

        }
        public bool HasHitMeOnBike { get; set; }
        public string SaySomethignNice { get; set; }

        public string Name { get; set; }
        public int Wheels { get; set; }
        public double Cost { get; set; }
        public bool IsLemon { get; set; }
        public bool IsOwnedByMusk { get; set; }

        public void KickTheVehicle()
        {
            Console.WriteLine("When you kick this car it sounds like this 'Thunk Thunk SCREEETCH");
        }

        public void WarrentyCenter()
        {
            Console.WriteLine($"When trying to sell you this car watch of for the 'cherrios in the car set'' insurance theyll try and sell you");
        }
    }
}
//In each of your car, truck, and suv classes

/*Create 2 members that are specific to each class
 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
 *
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 * 
 */