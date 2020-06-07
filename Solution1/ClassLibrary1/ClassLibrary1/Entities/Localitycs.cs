using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    class Localitycs
    {
        public int LocalitycsID { get; set; }
        public char Locality { get; set; }
        public char Region { get; set; }
        public char State { get; set; }
        public char Country { get; set; }
        public Inquiry Inquiry { get; set; }
    }
}
