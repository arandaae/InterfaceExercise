using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public string CargoHoldSize { get; set; }
        public string HasThirdRow { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public int HasWheels { get; set; }
        public string Engine { get; set; }
        public string HornSound { get; set; }
        public int NumberOfWindows { get; set; }
    }
}
