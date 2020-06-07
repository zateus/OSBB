using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
   public class TemperatureData
    {
        public int TemperatureDataID { get; set; }
        public double Temperature { get; set; }
        public double Huminity { get; set; }
        public int WindPower { get; set; }
        public Inquiry Inquiry { get; set; }
    }
}
