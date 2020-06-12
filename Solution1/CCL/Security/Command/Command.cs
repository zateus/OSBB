using System;
using System.Collections.Generic;
using System.Text;

namespace CCL.Security
{
    interface Command
    {
         void Execute();
         void Undo();
    }
}
