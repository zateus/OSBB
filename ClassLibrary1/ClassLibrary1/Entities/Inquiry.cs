using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    class Inquiry
    {
        public int InquiryID { get; set; }
        public char Date { get; set; }
        public List<TemparatureData> Data { get; set; }
        public List<Localitycs> Place { get; set; }
    }
}
