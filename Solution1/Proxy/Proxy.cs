using System;
using ClassLibrary1.Repositories.Interfaces;
using ClassLibrary1.Repositories.Impl;
using ClassLibrary1.Entities;
using System.Collections.Generic;
using CCL.Security.Identity;

namespace Proxy
{
    public class Proxy : IInquiry
    {
        InquiryRepository InquiryRepository;

        public string SomeState { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Accept(User visitor)
        {
            throw new NotImplementedException();
        }

        public void Create(Inquiry item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inquiry> Find(Func<Inquiry, bool> predicate, int pageNumber = 0, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public Inquiry Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inquiry> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Request()
        {
            if (InquiryRepository == null)
                InquiryRepository == new InquiryRepository();
            InquiryRepository.Request();
        }

        public void Update(Inquiry item)
        {
            throw new NotImplementedException();
        }
    }
}
