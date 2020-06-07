using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1.UnitOfWork;
using ClassLibrary1.Repositories.Impl;
using ClassLibrary1.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace ClassLibrary1.EF
{
    class EFUnitOfWork
         : IUnitOfWork
    {
        private InquiryContext db;
        private IInquiry Inquiry;
        private ITemperatureData TemperatureData;
        private ILocalitycs Locality;
​
        public EFUnitOfWork(DbContextOptions options)
        {
            db = new InquiryContext(options);
        }
        public IInquiry Inquiries
        {
            get
            {
                if (Inquiry == null)
                    Inquiry = new InquiryRepository(db);
                return Inquiry;
            }
        }
        public ILocalitycs Localitycs
        {
            get
            {
                if (Locality == null)
                    Locality = new LocalyticsRepository(db);
                return Locality;
            }
        }​
        public ITemperatureData TemperatureDatas
        {
            get
            {
                if (TemperatureData == null)
                    TemperatureData = new TemparatureDataRepository(db);
                return TemperatureData;
            }
        }
​
        public void Save()
        {
            db.SaveChanges();
        }
​
        private bool disposed = false;
​
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
​
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
