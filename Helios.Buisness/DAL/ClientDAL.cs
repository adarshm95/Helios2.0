using Buisness.DAL;
using Helios.Entity;
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
    public class ClientDAL
    {
        public static bool InsertClient(ClientModel _ClientModel)
        {
            bool result = false;
            try
            {
                if (_ClientModel != null)
                {
                    Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
                    DbCommand dbCommand = db.GetStoredProcCommand("sp_Client_ins");
                    db.AddInParameter(dbCommand, "@Client_Name", DbType.String, _ClientModel.Client_Name);
                    db.AddInParameter(dbCommand, "@Description", DbType.String, _ClientModel.Description);
                    db.AddInParameter(dbCommand, "@ActiveOn", DbType.DateTime, _ClientModel.ActiveOn);
                    db.AddInParameter(dbCommand, "@CreatedBy", DbType.Int32, _ClientModel.CreatedBy);
                    db.AddInParameter(dbCommand, "@CreatedDate", DbType.DateTime, _ClientModel.CreatedDate);
                    db.AddInParameter(dbCommand, "@UpdatedBy", DbType.Int32, _ClientModel.UpdatedBy);
                    db.AddInParameter(dbCommand, "@UpdatedDate", DbType.DateTime, _ClientModel.UpdatedDate);
                    db.AddInParameter(dbCommand, "@ActiveFlag", DbType.Boolean, _ClientModel.ActiveFlag);
                    int ret = db.ExecuteNonQuery(dbCommand);
                    if (ret > 0)
                        result = true;
                }

            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return result;
        }

        public static List<ClientModel> GetClientDetails(int id)
        {
            ClientModel _ClientModel = null;
            List<ClientModel> ClientModelList = new List<ClientModel>();
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
                DbCommand dbCommand = db.GetStoredProcCommand("sp_Client_get");
                if (id > 0)
                {
                    db.AddInParameter(dbCommand, "@Client_Id", DbType.Int32, id);
                }
                using (IDataReader dataReader = db.ExecuteReader(dbCommand))
                {
                    while (dataReader != null && dataReader.Read())
                    {
                        _ClientModel = new ClientModel();
                        _ClientModel.Client_Id = DataParser.GetSafeInt(dataReader, "Client_Id", 0);
                        _ClientModel.Client_Name = DataParser.GetSafeString(dataReader, "Client_Name", string.Empty);
                        _ClientModel.ActiveFlag = DataParser.GetSafeBool(dataReader, "ActiveFlag", false);
                        _ClientModel.ActiveOn = DataParser.GetSafeDateTime(dataReader, "ActiveOn", DateTime.Now);
                        _ClientModel.CreatedBy = DataParser.GetSafeInt(dataReader, "CreatedBy", 0);
                        _ClientModel.CreatedDate = DataParser.GetSafeDateTime(dataReader, "CreatedDate", DateTime.Now);
                        _ClientModel.Description = DataParser.GetSafeString(dataReader, "Description", string.Empty);
                        _ClientModel.UpdatedBy = DataParser.GetSafeInt(dataReader, "UpdatedBy", 0);
                        _ClientModel.UpdatedDate = DataParser.GetSafeDateTime(dataReader, "UpdatedDate", DateTime.Now);
                       
                        ClientModelList.Add(_ClientModel);
                    }
                }
            }
            catch (Exception ex)
            {
                string var = ex.Message;
            }
            return ClientModelList;
        }


        public static bool UpdateClient(ClientModel _ClientModel)
        {
            bool result = false;
            try
            {
                if (_ClientModel != null)
                {
                    Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
                    DbCommand dbCommand = db.GetStoredProcCommand("sp_Client_update");
                    db.AddInParameter(dbCommand, "@Client_Id", DbType.Int32, _ClientModel.Client_Id);
                    db.AddInParameter(dbCommand, "@Client_Name", DbType.String, _ClientModel.Client_Name);
                    db.AddInParameter(dbCommand, "@Description", DbType.String, _ClientModel.Description);
                    db.AddInParameter(dbCommand, "@ActiveOn", DbType.DateTime, _ClientModel.ActiveOn);
                    db.AddInParameter(dbCommand, "@CreatedBy", DbType.Int32, _ClientModel.CreatedBy);
                    db.AddInParameter(dbCommand, "@CreatedDate", DbType.DateTime, _ClientModel.CreatedDate);
                    db.AddInParameter(dbCommand, "@UpdatedBy", DbType.Int32, _ClientModel.UpdatedBy);
                    db.AddInParameter(dbCommand, "@UpdatedDate", DbType.DateTime, _ClientModel.UpdatedDate);
                    db.AddInParameter(dbCommand, "@ActiveFlag", DbType.Boolean, _ClientModel.ActiveFlag);
                    int ret = db.ExecuteNonQuery(dbCommand);
                    if (ret > 0)
                        result = true;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return result;
        }

        public static bool DeleteClient(ClientModel _ClientModel)
        {
            bool result = false;
            try
            {
                if (_ClientModel != null)
                {
                    Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
                    DbCommand dbCommand = db.GetStoredProcCommand("sp_Client_update");
                    db.AddInParameter(dbCommand, "@Client_Id", DbType.Int32, _ClientModel.Client_Id);
                    db.AddInParameter(dbCommand, "@Client_Name", DbType.String, _ClientModel.Client_Name);
                    db.AddInParameter(dbCommand, "@Description", DbType.String, _ClientModel.Description);
                    db.AddInParameter(dbCommand, "@ActiveOn", DbType.DateTime, _ClientModel.ActiveOn);
                    db.AddInParameter(dbCommand, "@CreatedBy", DbType.Int32, _ClientModel.CreatedBy);
                    db.AddInParameter(dbCommand, "@CreatedDate", DbType.DateTime, _ClientModel.CreatedDate);
                    db.AddInParameter(dbCommand, "@UpdatedBy", DbType.Int32, _ClientModel.UpdatedBy);
                    db.AddInParameter(dbCommand, "@UpdatedDate", DbType.DateTime, _ClientModel.UpdatedDate);
                    db.AddInParameter(dbCommand, "@ActiveFlag", DbType.Boolean, 0);
                    int ret = db.ExecuteNonQuery(dbCommand);
                    if (ret > 0)
                        result = true;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return result;
        }


    }
}
