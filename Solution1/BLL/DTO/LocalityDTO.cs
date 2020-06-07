using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
   public class LocalityDTO
    {
        public int LocalitycsID { get; set; }
        public char Locality { get; set; }
        public char Region { get; set; }
        public char State { get; set; }
        public char Country { get; set; }
    }
}
