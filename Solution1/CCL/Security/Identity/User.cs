﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CCL.Security.Identity
{
    public  class User
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
        public void VisitElementA(Inquiry elemA) { }
        public  void VisitElementB(Inquiry elemB) { }
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

       
    }
}


