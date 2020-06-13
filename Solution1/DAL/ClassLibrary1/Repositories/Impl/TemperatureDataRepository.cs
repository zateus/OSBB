using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1.Entities;
using ClassLibrary1.Repositories.Interfaces;
using ClassLibrary1.EF;

namespace ClassLibrary1.Repositories.Impl
{
    public class TemperatureDataRepository
         : BaseRepository<TemperatureData>, ITemperatureData
    {
​
        internal TemperatureDataRepository(InquiryContext context)
            : base(context)
        {
        }
    }

}
