using System;
using System.Collections.Generic;
using System.Text;

namespace CCL.Security.Identity
{
    public class Statistic
        : User
    {
        public Statistic(int userId, string name, int osbbId)
            : base(userId, name, osbbId, nameof(Admin))
        {
        }
    }
}

