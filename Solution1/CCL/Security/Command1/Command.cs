using System;
using System.Collections.Generic;
using System.Text;

namespace CCL.Security
{
    public interface Command
    {
         void Execute();
         void Undo();
    }
}
