using System;
using System.Collections.Generic;
using CCL.Security.Identity;
using ClassLibrary1.Repositories.Impl;
using ClassLibrary1.Repositories.Interfaces;
using ClassLibrary1.Entities;

namespace Visitor
{
    class Client
    {
        void Main()
        {
            var structure = new ObjectStructure();
            structure.Add(new BaseRepository<Inquiry>());
            
            structure.Accept(new ConcreteVisitor1());
        }
    }

   

    class ConcreteVisitor1 : User
    {
        
   

        public  void VisitElementA(BaseRepository<Inquiry> elemA)
        {
            elemA.OperationA();
        }

      

        public void VisitElementB(BaseRepository<Inquiry> elemB)
        {
            elemB.OperationA();
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
