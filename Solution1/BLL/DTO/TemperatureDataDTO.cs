using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class TemperatureDataDTO
    {
        public int TemperatureDataID { get; set; }
        public double Temperature { get; set; }
        public double Huminity { get; set; }
        public int WindPower { get; set; }
    }
}
