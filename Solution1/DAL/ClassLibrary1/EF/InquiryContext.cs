using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.EF
{
    public class InquiryContext
      : DbContext
    {
        public DbSet<Inquiry> Inquiries { get; set; }
        public DbSet<TemperatureData> TemparatureDatas { get; set; }
        public DbSet<Localitycs> Localitycs { get; set; }

        public InquiryContext(DbContextOptions options)
            : base(options)
        {
        }

    }
}
