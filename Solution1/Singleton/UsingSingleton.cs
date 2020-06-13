using System;
using System.Collections.Generic;
using System.Text;

using ClassLibrary1.Repositories.Impl;
using Singleton;
namespace Singleton
{
    class UsingSingleton
    {
        static void Main(string[] args)
        {
            Inquiry inquiry = new Inquiry
            {
                InquiryID = 1
            };
            Console.WriteLine(inquiry.Singleton.ID);

            // у нас не получится изменить ОС, так как объект уже создан    
            inquiry.Singleton = Singleton.getInstance("10");
            Console.WriteLine(inquiry.Singleton.ID);

            Console.ReadLine();
        }
    }
    public class Inquiry
    {
        public int InquiryID { get; set; }
        public char Date { get; set; }
        public Singleton Singleton { get; set; }

    }
}
