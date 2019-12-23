using Helios.Entity.Models;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helios.Buisness.DAL
{
    public class AuditDAL
    {
        public static bool InsertAuditDetails(AuditModel _AuditModel)
        {
            bool result=false;
            try
            {
                if (_AuditModel != null)
                {
                    Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
                    DbCommand dbCommand = db.GetStoredProcCommand("sp_Audit_Details_ins");
                    db.AddInParameter(dbCommand, "@Module_name", DbType.String, _AuditModel.Module_name);
                    db.AddInParameter(dbCommand, "@Log_date", DbType.DateTime, _AuditModel.Log_date);
                    db.AddInParameter(dbCommand, "@Function_name", DbType.String, _AuditModel.Function_name);
                    db.AddInParameter(dbCommand, "@Description", DbType.String, _AuditModel.Description);
                    db.AddInParameter(dbCommand, "@Is_error", DbType.Boolean, _AuditModel.Is_error);
                    int ret = db.ExecuteNonQuery(dbCommand);
                    if (ret > 0)
                        result = true;
                }
            }
            catch (Exception ex)
            {

                //throw;
            }
            return result;
        }
    }
}
