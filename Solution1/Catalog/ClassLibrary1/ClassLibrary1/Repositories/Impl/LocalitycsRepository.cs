using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1.Entities;
using ClassLibrary1.Repositories.Interfaces;
using ClassLibrary1.EF;

namespace ClassLibrary1.Repositories.Impl
{
   public class LocalyticsRepository
           : BaseRepository<Localitycs>, ILocalitycs
    {
​
        internal LocalyticsRepository(InquiryContext context)
            : base(context)
        {
        }
    }

}
