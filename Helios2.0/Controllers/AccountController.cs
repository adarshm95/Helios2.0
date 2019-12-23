using Helios.Buisness;
using Helios.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Helios2._0.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel _LoginModel)
        {
            try
            {
                AuditModel _AuditModel = new AuditModel();
                _AuditModel.Module_name = "Login Module";
                bool AuditResult;
                if (Membership.ValidateUser(_LoginModel.Username, _LoginModel.Password))
                {
                    FormsAuthentication.SetAuthCookie(_LoginModel.Username, _LoginModel.RememberMe);
                    string Msg = _LoginModel.Username + " successfully Logged in on " + DateTime.Now.ToString();
                    _AuditModel.Function_name = "Employee";
                    _AuditModel.Is_error = false;
                    _AuditModel.Description = Msg;
                    AuditResult = AuditLog(_AuditModel);
                    return this.RedirectToAction("Employee", "Employee");
                }
                else
                {
                    string Msg = _LoginModel.Username + " failed to login at " + DateTime.Now.ToString();
                    _AuditModel.Function_name = "Login";
                    _AuditModel.Is_error = false;
                    _AuditModel.Description = Msg;
                    AuditResult = AuditLog(_AuditModel);
                    ViewBag.msg = "Invalid Username or Password";
                }
            }
            catch (Exception ex)
            {
                ViewBag.msg = ex.Message;
            }
            return View();
        }

        public bool AuditLog(AuditModel _AuditModel)
        {           
            bool ret=false;
            try
            {
                AuditBL _AuditBL = new AuditBL();
                _AuditModel.Log_date = DateTime.Now;
                ret = _AuditBL.InsertAuditBL(_AuditModel);
            }
            catch (Exception ex)
            {
                ViewBag.msg = ex.Message;
            }
            return ret;
        }

    }
}