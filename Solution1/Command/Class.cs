using System;
using CCL.Security;
using CCL.Security.Identity;
namespace Command
{
    
    class Client
    {
        void Main()
        {
            User invoker = new User(1,"Fag",3,"User");
            Admin receiver = new Admin(2,"Alex",12);
            UsingCommand command = new UsingCommand(receiver);
            invoker.SetCommand(command);
            invoker.Run();
        }
    }
}
