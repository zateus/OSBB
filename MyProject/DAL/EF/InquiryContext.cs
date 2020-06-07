using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.EF
{
    class InquiryContext
      : DbContext
    {
        public DbSet<Inquiry> Inquiries { get; set; }
        public DbSet<TemparatureData> TemparatureDatas { get; set; }
        public DbSet<Localitycs> Localitycs { get; set; }

        public InquiryContext(DbContextOptions options)
            : base(options)
        {
        }

    }
}
