using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    public class Inquiry
    {
        public int InquiryID { get; set; }
        public char Date { get; set; }
        public List<TemperatureData> Data { get; set; }
        public List<Localitycs> Place { get; set; }
       
    }
}
