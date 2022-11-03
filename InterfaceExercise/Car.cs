using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : ICompany , IVehicle
    {
        public Car()
        {

        }
        public bool CanBounce { get; set; }
        public string GradeThisCar { get; set; }

        public string Name { get ; set ; }
        public int Wheels { get ; set ; }
        public double Cost { get ; set; }
        public bool IsLemon { get ; set ; }
        public bool IsOwnedByMusk { get; set ; }
       

        public void KickTheVehicle()
        {
            Console.WriteLine("When you kick this car, it will sound a sack of worthless joke cryptos scattered on the street");
        }

        public void WarrentyCenter()
        {
            Console.WriteLine("When you buy this car, watch that they dont try to sneak in a provision forcing you to buy Twitter as well.");
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