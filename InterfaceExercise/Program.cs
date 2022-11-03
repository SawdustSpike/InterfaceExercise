using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var vList = new List<IVehicle>();
            var f150 = new Truck()
            {
                HasOffensiveBumperStickers = true,
                HasTruckNuts = true,
                Name = "Ford F150",
                Wheels = 4,
                Cost = 34585,
                IsLemon = false,
                IsOwnedByMusk = false,
            };
            var tesla = new Car()
            {
                CanBounce = false,
                GradeThisCar = "B+",
                Name = "Tesla Coil I think, I'm not looking it up",
                Wheels = 4,
                Cost = 45000,
                IsLemon = false,
                IsOwnedByMusk = true,
            }; 
            SUV crV = new()
            {
                HasHitMeOnBike = true,
                SaySomethignNice = "It has a sturdy windsheild",
                Name = "CR-V",
                Wheels = 4,
                Cost = 33550,
                IsLemon = true,
                IsOwnedByMusk = false,
            };
            vList.Add(crV);
            vList.Add(tesla);
            vList.Add(f150);
            foreach(var v in vList)
            {
                Console.WriteLine($"Hey, wanna buy a {v.Name}? It's got {v.Wheels} wheels and only costs ${v.Cost}. I'm sure you'll love it.");
                v.KickTheVehicle();            
            }
        }
    }
}

