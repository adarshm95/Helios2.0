using Helios.Buisness.DAL;
using Helios.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helios.Buisness
{
    public class AuditBL
    {
        public bool InsertAuditBL(AuditModel _AuditModel)
        {
            bool ret = AuditDAL.InsertAuditDetails(_AuditModel);
            return ret;
        }
    }
}
