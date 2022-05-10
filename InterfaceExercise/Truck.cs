﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public string BedSize { get; set; }
        public bool HasExtendedCab { get; set; }
        public int HasWheels { get; set; }
        public string Engine { get; set; }
        public string HornSound { get; set; }
        public int NumberOfWindows { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
    }
}
