using System;
using System.Collections.Generic;
using CCL.Security.Identity;
using ClassLibrary1.Repositories.Impl;
using ClassLibrary1.Repositories.Interfaces;
using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;
namespace Visitor
{
    class Client
    {
        void Main()
        {
            DbContext context = new DbContext();
            var structure = new ObjectStructure();
            structure.Add(new BaseRepository<Inquiry>( context));
            
            structure.Accept(new ConcreteVisitor1());
        }
    }

   

    class ConcreteVisitor1 : User
    {

        User User = new User(1, "B", 3, "D");

        public  void VisitElementA(BaseRepository<Inquiry> elemA)
        {
            elemA.OperationA();
        }

        public void VisitElementA(Inquiry elemA)
        {
            throw new NotImplementedException();
        }

       

        public void VisitElementB(BaseRepository<Inquiry> elemB)
        {
            elemB.OperationA();
        }

        public void VisitElementB(Inquiry elemB)
        {
            throw new NotImplementedException();
        }
    }
    

    class ObjectStructure
    {
        List<BaseRepository<Inquiry>> elements = new List<BaseRepository<Inquiry>>();
        public void Add(BaseRepository<Inquiry> element)
        {
            elements.Add(element);
        }
        public void Remove(BaseRepository<Inquiry> element)
        {
            elements.Remove(element);
        }
        public void Accept(User visitor)
        {
            foreach (BaseRepository<Inquiry> element in elements)
                element.Accept(visitor);
        }
    }

   

    
}
