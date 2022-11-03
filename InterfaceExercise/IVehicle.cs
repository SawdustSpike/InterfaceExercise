using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Name { get; set; }
        public int Wheels { get; set; } 
        public double Cost { get; set; }
        public bool IsLemon { get; set; }
        public void KickTheVehicle();   

        
    }
}

//In your IVehicle

/* Create 4 members that Car, Truck, & SUV all have in common.
 * Example: All vehicles have a number of wheels... for now..
 */