using System;
using System.Collections.Generic;
using System.Text;
using CCL.Security.Identity;
namespace CCL.Security
{
    public class UsingCommand: Command
    {
        Admin receiver;
        public UsingCommand(Admin r)
        {
            receiver = r;
        }
        public  void Execute()
        {
            receiver.Operation();
        }

        public  void Undo()
        { }
    }
}
