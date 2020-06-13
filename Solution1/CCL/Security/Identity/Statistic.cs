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

        public override void VisitElementA(Inquiry elemA)
        {
            throw new NotImplementedException();
        }

        public override void VisitElementB(Inquiry elemB)
        {
            throw new NotImplementedException();
        }
    }
}

