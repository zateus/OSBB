using System;
using System.Collections.Generic;
using System.Text;

namespace CCL.Security.Identity
{
    public abstract class User
    {
        public User(int userId, string name, int InquiryId, string userType)
        {
            UserId = userId;
            Name = name;
            InquiryID = InquiryId;
            UserType = userType;
        }
        public int UserId { get; }
        public string Name { get; }
        public int InquiryID { get; }
        protected string UserType { get; }
        public abstract void VisitElementA(Inquiry elemA);
        public abstract void VisitElementB(Inquiry elemB);
        Command command;
        public void SetCommand(Command c)
        {
            command = c;
        }
        public void Run()
        {
            command.Execute();
        }
        public void Cancel()
        {
            command.Undo();
        }

        public void VisitElementA<T>(global::ClassLibrary1.Repositories.Impl.BaseRepository<T> baseRepository) where T : class
        {
            throw new NotImplementedException();
        }

        public void VisitElementA<T>(global::ClassLibrary1.Repositories.Impl.BaseRepository<T> baseRepository) where T : class
        {
            throw new NotImplementedException();
        }

        public void VisitElementA<T>(global::ClassLibrary1.Repositories.Impl.BaseRepository<T> baseRepository) where T : class
        {
            throw new NotImplementedException();
        }

        public abstract void VisitElementA<T>(global::ClassLibrary1.Repositories.Impl.BaseRepository<T> baseRepository) where T : class;
    }
}


