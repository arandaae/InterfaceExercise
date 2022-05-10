using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle : ICompany
    {
        public int HasWheels { get; set; }
        public string Engine { get; set; }
        public string HornSound { get; set; }
        public int NumberOfWindows { get; set; }

    }
}
