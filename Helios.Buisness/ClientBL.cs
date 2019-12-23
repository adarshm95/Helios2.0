using Helios.Buisness.DAL;
using Helios.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helios.Buisness
{
    public class ClientBL
    {
        public bool InsertClientBL(ClientModel _ClientModel)
        {
            bool result = ClientDAL.InsertClient(_ClientModel);
            return result;
        }

        public List<ClientModel> GetClientDetails(int id)
        {
            List<ClientModel> ClientModelList = new List<ClientModel>();
            ClientModelList = ClientDAL.GetClientDetails(id);
            return ClientModelList;
        }

        public bool UpdateClientBL(ClientModel _ClientModel)
        {
            bool result = ClientDAL.UpdateClient(_ClientModel);
            return result;
        }
        public bool DeleteClientBL(ClientModel _ClientModel)
        {
            bool result = ClientDAL.DeleteClient(_ClientModel);
            return result;
        }
    }
}
