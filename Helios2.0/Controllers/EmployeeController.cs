using Helios.Buisness;
using Helios.Entity;
using Helios.Entity.Models;
using Helios2._0.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helios2._0.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetEmployeeOfficial()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetEmployeeOfficial(int id)
        {
            EmployeeBL _EmployeeBL = new EmployeeBL();
            List<EmployeeOfficialModel> _EmployeeOfficialList = _EmployeeBL.GetEmployeeOfficial(id);
            return Json(_EmployeeOfficialList, JsonRequestBehavior.AllowGet);

        }
        [HttpGet]
        public PartialViewResult NewEmployeeOfficial(int Employee_profile_id)
        {
            EmployeeOfficialModel _EmployeeOfficialModel = new EmployeeOfficialModel();
            _EmployeeOfficialModel.Employee_proile_id = Employee_profile_id;

          
            EmployeeBL _EmployeeBL = new EmployeeBL();
            bool result = _EmployeeBL.InsertEmployeeOfficial(_EmployeeOfficialModel);

            List<Department> departmentList = new List<Department>();
            departmentList = _EmployeeBL.GetDepartment();
            ViewBag.Department = departmentList;

            List<EmployeeRole> EmployeeRoleList = new List<EmployeeRole>();
            EmployeeRoleList = _EmployeeBL.GetEmployeeRole();
            ViewBag.EmployeeRole = EmployeeRoleList;

            List<EmployeeType> EmployeeTypeList = new List<EmployeeType>();
            EmployeeTypeList = _EmployeeBL.GetEmployeeType();
            ViewBag.EmployeeType = EmployeeTypeList;

            List<OrganizationUnit> OrganizationUnitList = new List<OrganizationUnit>();
            OrganizationUnitList = _EmployeeBL.GetOrganizationUnit();
            ViewBag.OrganizationUnit = OrganizationUnitList;

            List<PersonalProfileModel> managerList = new List<PersonalProfileModel>();
            managerList = _EmployeeBL.GetManager();
            ViewBag.managers = managerList;

            List<PersonalProfileModel> hrmanagerList = new List<PersonalProfileModel>();
            hrmanagerList = _EmployeeBL.GetHRManager();
            ViewBag.hrmanagers = hrmanagerList;

            List<PersonalProfileModel> hiringmanagerList = new List<PersonalProfileModel>();
            hiringmanagerList = _EmployeeBL.GetHiringManager();
            ViewBag.hiringManagers = hiringmanagerList;

            List<PersonalProfileModel> supervisorList = new List<PersonalProfileModel>();
            supervisorList = _EmployeeBL.GetSupervisor();
            ViewBag.supervisors = supervisorList;

            return PartialView(_EmployeeOfficialModel);
        }

        [HttpPost]
        public PartialViewResult NewEmployeeOfficial(EmployeeOfficialModel _EmployeeOfficialModel)
        {
             EmployeeBL _EmployeeBL = new EmployeeBL();
            List<Department> departmentList = new List<Department>();
            departmentList = _EmployeeBL.GetDepartment();
            ViewBag.Department = departmentList;

            List<EmployeeRole> EmployeeRoleList = new List<EmployeeRole>();
            EmployeeRoleList = _EmployeeBL.GetEmployeeRole();
            ViewBag.EmployeeRole = EmployeeRoleList;

            List<EmployeeType> EmployeeTypeList = new List<EmployeeType>();
            EmployeeTypeList = _EmployeeBL.GetEmployeeType();
            ViewBag.EmployeeType = EmployeeTypeList;

            List<OrganizationUnit> OrganizationUnitList = new List<OrganizationUnit>();
            OrganizationUnitList = _EmployeeBL.GetOrganizationUnit();
            ViewBag.OrganizationUnit = OrganizationUnitList;

            List<PersonalProfileModel> managerList = new List<PersonalProfileModel>();
            managerList = _EmployeeBL.GetManager();
            ViewBag.managers = managerList;

            List<PersonalProfileModel> hrmanagerList = new List<PersonalProfileModel>();
            hrmanagerList = _EmployeeBL.GetHRManager();
            ViewBag.hrmanagers = hrmanagerList;

            List<PersonalProfileModel> hiringmanagerList = new List<PersonalProfileModel>();
            hiringmanagerList = _EmployeeBL.GetHiringManager();
            ViewBag.hiringManagers = hiringmanagerList;

            List<PersonalProfileModel> supervisorList = new List<PersonalProfileModel>();
            supervisorList = _EmployeeBL.GetSupervisor();
            ViewBag.supervisors = supervisorList;

            bool result = _EmployeeBL.InsertEmployeeOfficial(_EmployeeOfficialModel);
            return PartialView();
        }
        
        public ActionResult Employee()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult NewPersonalProfile()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult NewPersonalProfile(PersonalProfileModel _PersonalProfileModel)
        {
            if (ModelState.IsValid)
            {
                EmployeeBL _EmployeeBL = new EmployeeBL();
                int result = _EmployeeBL.InsertPersonalProfile(_PersonalProfileModel);
            }
            return PartialView();
        }

        [HttpGet]
        public ActionResult PersonalProfileList()
        {
            return View();
        }
        [HttpPost]
        public JsonResult PersonalProfileList(int id)
        {
            EmployeeBL EmployeeBLobj = new EmployeeBL();
            List<PersonalProfileModel> _PersonalProfileModelList = EmployeeBLobj.GetPersonalProfile(id);
            return Json(_PersonalProfileModelList, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult PersonalProfileView(int id)
        {
            List<PersonalProfileModel> PersonalProfileModelList = new List<PersonalProfileModel>();
            PersonalProfileModel _PersonalProfileModel = new PersonalProfileModel();
            EmployeeBL _EmployeeBL = new EmployeeBL();
            PersonalProfileModelList = _EmployeeBL.GetPersonalProfile(id);
            foreach (var v in PersonalProfileModelList)
            {
                _PersonalProfileModel = v;
            }

            return View(_PersonalProfileModel);
        }
        [HttpPost]
        public ActionResult PersonalProfileView(PersonalProfileModel _PersonalProfileModel)
        {
            EmployeeBL _EmployeeBL = new EmployeeBL();
            bool result = _EmployeeBL.UpdatePersonalProfile(_PersonalProfileModel);
            if (result == true)
            {
                return RedirectToAction("PersonalProfileList");
            }
            else
            {
                return View(_PersonalProfileModel);
            }
           
        }
        
        [HttpGet]
        public ActionResult EmployeeOfficialList()
        {
            return View();
        }
        [HttpPost]
        public JsonResult EmployeeOfficialList(int id)
        {
            EmployeeBL _EmployeeBLObj = new EmployeeBL();
            List<EmployeeOfficialModel> _EmployeeOfficialModelList = _EmployeeBLObj.GetEmployeeOfficial(id);
            return Json(_EmployeeOfficialModelList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult EmployeeOfficialView(int id)
        {
            List<EmployeeOfficialModel> EmployeeOfficialModelList = new List<EmployeeOfficialModel>();
            EmployeeOfficialModel _EmployeeOfficialModel = new EmployeeOfficialModel();
            EmployeeBL _EmployeeBL = new EmployeeBL();
            List<Department> departmentList = new List<Department>();
            departmentList = _EmployeeBL.GetDepartment();
            ViewBag.Department = departmentList;

            List<EmployeeRole> EmployeeRoleList = new List<EmployeeRole>();
            EmployeeRoleList = _EmployeeBL.GetEmployeeRole();
            ViewBag.EmployeeRole = EmployeeRoleList;

            List<EmployeeType> EmployeeTypeList = new List<EmployeeType>();
            EmployeeTypeList = _EmployeeBL.GetEmployeeType();
            ViewBag.EmployeeType = EmployeeTypeList;

            List<OrganizationUnit> OrganizationUnitList = new List<OrganizationUnit>();
            OrganizationUnitList = _EmployeeBL.GetOrganizationUnit();
            ViewBag.OrganizationUnit = OrganizationUnitList;

            List<PersonalProfileModel> managerList = new List<PersonalProfileModel>();
            managerList = _EmployeeBL.GetManager();
            ViewBag.managers = managerList;

            List<PersonalProfileModel> hrmanagerList = new List<PersonalProfileModel>();
            hrmanagerList = _EmployeeBL.GetHRManager();
            ViewBag.hrmanagers = hrmanagerList;

            List<PersonalProfileModel> hiringmanagerList = new List<PersonalProfileModel>();
            hiringmanagerList = _EmployeeBL.GetHiringManager();
            ViewBag.hiringManagers = hiringmanagerList;

            List<PersonalProfileModel> supervisorList = new List<PersonalProfileModel>();
            supervisorList = _EmployeeBL.GetSupervisor();
            ViewBag.supervisors = supervisorList;
            EmployeeOfficialModelList = _EmployeeBL.GetEmployeeOfficial(id);
           
            if(EmployeeOfficialModelList!=null)
            _EmployeeOfficialModel = EmployeeOfficialModelList.FirstOrDefault();


            return View(_EmployeeOfficialModel);
        }
        [HttpPost]
        public ActionResult EmployeeOfficialView(EmployeeOfficialModel _EmployeeOfficialModel)
        {
            EmployeeBL _EmployeeBL = new EmployeeBL();
            bool result = _EmployeeBL.UpdateEmployeeOfficial(_EmployeeOfficialModel);
            if (result == true)
            {
                return RedirectToAction("EmployeeOfficialList");
            }
            else
            {
                return View(_EmployeeOfficialModel);
            }

        }

        public ActionResult TimesheetView()
        {
            return View();
        }
    }
    
}