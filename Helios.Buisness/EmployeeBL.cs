using Helios.Buisness.DAL;
using Helios.Entity;
using Helios.Entity.Models;
using Helios2._0.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helios.Buisness
{
    public class EmployeeBL
    {
        public int InsertPersonalProfile(PersonalProfileModel _PersonalProfileModel)
        {
            int result = 0;
            if (_PersonalProfileModel != null)
            {
                result = EmployeeProfileDAL.InsertPersonalProfile(_PersonalProfileModel);
            }
            return result;
        }

        public List<PersonalProfileModel> GetPersonalProfile(int id)
        {
            List<PersonalProfileModel> PersonalProfileModelList = EmployeeProfileDAL.GetPersonalProfile(id);
            return PersonalProfileModelList;
        }

        public bool UpdatePersonalProfile(PersonalProfileModel _PersonalProfileModel)
        {
            bool result = EmployeeProfileDAL.UpdatePersonalProfile(_PersonalProfileModel);
            return result;
        }
        public int NewProjects(ProjectsModel _ProjectsModel)
        {
            int result = 0;
            if (_ProjectsModel != null)
            {
                result = EmployeeProfileDAL.NewProjects(_ProjectsModel);
            }
            return result;
        }
        public List<ProjectsModel> GetProject(int id)
        {
            List<ProjectsModel> ProjectsModelList = EmployeeProfileDAL.GetProject(id);
            return ProjectsModelList;
        }
        public List<ClientModel> GetClient(int id)
        {
            List<ClientModel> ClientModelList = ClientDAL.GetClientDetails(id);
            return ClientModelList;
        }
        public bool UpdateProject(ProjectsModel _ProjectsModel)
        {
            bool result = EmployeeProfileDAL.UpdateProject(_ProjectsModel);
            return result;
        }

        public  List<EmployeeOfficialModel> GetEmployeeOfficial(int id)
        {
            List<EmployeeOfficialModel> officialList = EmployeeProfileDAL.GetEmployeeOfficial(id);
            return officialList;
        }

        public bool InsertEmployeeOfficial(EmployeeOfficialModel _EmployeeOfficialModel)
        {
            bool result = false;
            if(_EmployeeOfficialModel!=null)
            {
                result = EmployeeProfileDAL.InsertEmployeeOfficial(_EmployeeOfficialModel);
            }
            return result;
        }

        public bool UpdateEmployeeOfficial(EmployeeOfficialModel _EmployeeOfficialModel)
        {
            bool result = EmployeeProfileDAL.UpdateEmployeeOfficial(_EmployeeOfficialModel);
            return result;
        }

        public List<EmployeeRole> GetEmployeeRole()
        {
            List<EmployeeRole> rolelist = EmployeeProfileDAL.GetEmployeeRole();
            return rolelist;
        }

        public List<Department> GetDepartment()
        {
            List<Department> departmentlist = EmployeeProfileDAL.GetDepartment();
            return departmentlist;
        }
        public List<EmployeeType> GetEmployeeType()
        {
            List<EmployeeType> typeList = EmployeeProfileDAL.GetEmployeeType();
            return typeList;
        }
        public List<OrganizationUnit> GetOrganizationUnit()
        {
            List<OrganizationUnit> organizationList = EmployeeProfileDAL.GetOrganizationUnit();
            return organizationList;
        }

        public List<PersonalProfileModel> GetManager()
        {
            List<PersonalProfileModel> managerList = EmployeeProfileDAL.GetManager();
            return managerList;
        }

        public List<PersonalProfileModel> GetSupervisor()
        {
            List<PersonalProfileModel> supervisorList = EmployeeProfileDAL.GetSupervisor();
            return supervisorList;
        }

        public List<PersonalProfileModel> GetHRManager()
        {
            List<PersonalProfileModel> hrmanagerList = EmployeeProfileDAL.GetHRManager();
            return hrmanagerList;
        }
        public List<PersonalProfileModel> GetHiringManager()
        {
            List<PersonalProfileModel> hiringManagerList = EmployeeProfileDAL.GetHiringManager();
            return hiringManagerList;
        }
            
    }
}
