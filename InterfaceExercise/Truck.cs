using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public Truck()
        {

        }
        public bool HasTruckNuts { get; set; }
        public bool HasOffensiveBumperStickers { get; set; }
        public string Name { get; set; }
        public int Wheels { get; set; }
        public double Cost { get; set; }
        public bool IsLemon { get; set; }
        public bool IsOwnedByMusk { get; set; }

        public void KickTheVehicle()
        {
            Console.WriteLine("When you kick this truck, it'll sound like Keith Urban stepping on a lego");
        }

        public void WarrentyCenter()
        {
            Console.WriteLine("When you go to buy this, watch that they dont sell you mudding insurance aong with it.");
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