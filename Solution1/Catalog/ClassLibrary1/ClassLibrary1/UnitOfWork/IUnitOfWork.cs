using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1.Repositories.Interfaces;
using ClassLibrary1.Entities;

namespace ClassLibrary1.UnitOfWork
{
   public interface IUnitOfWork : IDisposable
    {
        IInquiry Inquiries { get; }
        ILocalitycs Localitycs { get; }
        ITemperatureData TemperatureDatas { get; }
        void Save();
    }
}
