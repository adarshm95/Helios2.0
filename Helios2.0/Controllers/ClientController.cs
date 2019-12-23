using Helios.Buisness;
using Helios.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helios2._0.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddClient(ClientModel _ClientModel)
        {
            if (ModelState.IsValid)
            {
                ClientBL _ClientBL = new ClientBL();
                bool ret = _ClientBL.InsertClientBL(_ClientModel);
                if (ret == true)
                {
                    ViewBag.message = "Client Added";
                }
                else
                {
                    ViewBag.message = "Insertion Failed";
                }
            }
           
            return View();
        }

        [HttpGet]
        public ActionResult ClientList()
        {

            return View();
        }

        [HttpPost]
        public JsonResult GetClients(string id)
        {
            ClientBL _ClientBL = new ClientBL();
            List<ClientModel> clientModelList = new List<ClientModel>();
            clientModelList = _ClientBL.GetClientDetails(int.Parse(id));
            return Json(clientModelList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult EditClient(int id)
        {
            ClientBL _ClientBL = new ClientBL();
            List<ClientModel> ClientModelList = new List<ClientModel>();
            ClientModel _ClientModel = new ClientModel();
            ClientModelList = _ClientBL.GetClientDetails(id);
            foreach(var v in ClientModelList)
            {
                _ClientModel = v;
                //var shortdate= _ClientModel.CreatedDate.ToString("yyyy-MM-dd");
                //_ClientModel.CreatedDate = Convert.ToDateTime(shortdate);
            }
            return View(_ClientModel);
        }

        [HttpPost]
        public ActionResult EditClient(ClientModel _ClientModel)
        {
            ClientBL _ClientBL = new ClientBL();
            bool ret = _ClientBL.UpdateClientBL(_ClientModel);
            return RedirectToAction("ClientList");
        }

        [HttpDelete]
        public ActionResult ClientList(ClientModel _ClientModel)
        {
            ClientBL _ClientBL = new ClientBL();
            bool ret = _ClientBL.DeleteClientBL(_ClientModel);

            return View();
            
        }


    }
}