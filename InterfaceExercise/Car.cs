using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int HasWheels { get; set; }
        public string Engine { get; set; }
        public string HornSound { get; set; }
        public int NumberOfWindows { get; set; }
        public string Name { get; set; }  
        public string Logo { get; set; }
        public string HasTrunk { get; set; }
        public string BetterMilage { get; set; }
    }
}
