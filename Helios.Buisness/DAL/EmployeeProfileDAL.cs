using Buisness.DAL;
using Helios.Entity;
using Helios.Entity.Models;

using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
namespace Helios2._0.DAL
{
    public class EmployeeProfileDAL
    {
        //For Creating new Personal profile 
        public static int InsertPersonalProfile(PersonalProfileModel _PersonalProfileModel)
        {
            int Employee_profile_id = 0;

            try
            {

                if (_PersonalProfileModel != null)
                {
               
                    Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
                    DbCommand dbCommand = db.GetStoredProcCommand("sp_Personal_Profile_ins");
                    db.AddInParameter(dbCommand, "@Employee_name", DbType.String, _PersonalProfileModel.Employee_name);
                    db.AddInParameter(dbCommand, "@Prefered_name", DbType.String, _PersonalProfileModel.Prefered_name);
                    db.AddInParameter(dbCommand, "@Nationality", DbType.String, _PersonalProfileModel.Nationality);
                    db.AddInParameter(dbCommand, "@DOB", DbType.DateTime, _PersonalProfileModel.DOB);
                    db.AddInParameter(dbCommand, "@Gender", DbType.String, _PersonalProfileModel.Gender);
                    db.AddInParameter(dbCommand, "@Phone_number", DbType.String, _PersonalProfileModel.Phone_number);
                    db.AddInParameter(dbCommand, "@Email", DbType.String, _PersonalProfileModel.Email);
                    db.AddInParameter(dbCommand, "@Mobile_number", DbType.String, _PersonalProfileModel.Mobile_number);
                    db.AddInParameter(dbCommand, "@Image_url", DbType.String, _PersonalProfileModel.Image_url);
                    db.AddInParameter(dbCommand, "@Network_id", DbType.String, _PersonalProfileModel.Network_id);
                    db.AddInParameter(dbCommand, "@Created_by", DbType.Int32, _PersonalProfileModel.Created_by);
                    db.AddInParameter(dbCommand, "@Updated_by", DbType.Int32, _PersonalProfileModel.Updated_by);
                    db.AddInParameter(dbCommand, "@Active_flag", DbType.Boolean, _PersonalProfileModel.Active_flag);
                    Employee_profile_id = (int)db.ExecuteScalar(dbCommand);


                }
            }
            catch (Exception ex)
            {
                string var = ex.Message;
            }
            return Employee_profile_id;
        }
        //For geting Personal profile list
        public static List<PersonalProfileModel> GetPersonalProfile(int id)
        {
            PersonalProfileModel _PersonalProfileModel = null;
            List<PersonalProfileModel> PersonalProfileModelList = new List<PersonalProfileModel>();
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
                DbCommand dbCommand = db.GetStoredProcCommand("sp_Personal_Profile_get");
                if (id > 0)
                {
                    db.AddInParameter(dbCommand, "@Employee_profile_id", DbType.Int32, id);
                } 
                using (IDataReader dataReader = db.ExecuteReader(dbCommand))
                {
                    while (dataReader != null && dataReader.Read())
                    {
                        _PersonalProfileModel = new PersonalProfileModel();
                        _PersonalProfileModel.Employee_profile_id = DataParser.GetSafeInt(dataReader, "Employee_profile_id", 0);
                        _PersonalProfileModel.Employee_name = DataParser.GetSafeString(dataReader, "Employee_name", string.Empty);
                        _PersonalProfileModel.Prefered_name = DataParser.GetSafeString(dataReader, "Prefered_name", string.Empty);
                        _PersonalProfileModel.Nationality = DataParser.GetSafeString(dataReader, "Nationality", string.Empty);
                        _PersonalProfileModel.DOB = DataParser.GetSafeDateTime(dataReader, "DOB", DateTime.Now);
                        _PersonalProfileModel.Gender = DataParser.GetSafeString(dataReader, "Gender", string.Empty);
                        _PersonalProfileModel.Phone_number= DataParser.GetSafeString(dataReader, "Phone_number", string.Empty);
                        _PersonalProfileModel.Email = DataParser.GetSafeString(dataReader, "Email", string.Empty);
                        _PersonalProfileModel.Mobile_number = DataParser.GetSafeString(dataReader, "Mobile_number", string.Empty);
                        _PersonalProfileModel.Image_url = DataParser.GetSafeString(dataReader, "Image_url", string.Empty);
                        _PersonalProfileModel.Network_id = DataParser.GetSafeString(dataReader, "Network_id", string.Empty);
                        _PersonalProfileModel.Created_by = DataParser.GetSafeInt(dataReader, "Created_by", 0);
                        _PersonalProfileModel.Created_date = DataParser.GetSafeDateTime(dataReader, "Created_date", DateTime.Now);
                        _PersonalProfileModel.Updated_by = DataParser.GetSafeInt(dataReader, "Updated_by", 0);
                        _PersonalProfileModel.Updated_date = DataParser.GetSafeDateTime(dataReader, "Updated_date", DateTime.Now);
                        _PersonalProfileModel.Active_flag = DataParser.GetSafeBool(dataReader, "Active_flag", true);
                        PersonalProfileModelList.Add(_PersonalProfileModel);
                    }
                }
            }
            catch (Exception ex)
            {
                string var = ex.Message;
            }
            return PersonalProfileModelList;
        }
        //For updating Personal profile details
        public static bool UpdatePersonalProfile(PersonalProfileModel _PersonalProfileModel)
        {
            bool result = false;
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
                DbCommand dbCommand = db.GetStoredProcCommand("sp_Personal_Profile_upd");
                db.AddInParameter(dbCommand, "@Employee_profile_id", DbType.Int32, _PersonalProfileModel.Employee_profile_id);
                db.AddInParameter(dbCommand, "@Employee_name", DbType.String, _PersonalProfileModel.Employee_name);
                db.AddInParameter(dbCommand, "@Prefered_name", DbType.String, _PersonalProfileModel.Prefered_name);
                db.AddInParameter(dbCommand, "@Nationality", DbType.String, _PersonalProfileModel.Nationality);
                db.AddInParameter(dbCommand, "@DOB", DbType.DateTime, _PersonalProfileModel.DOB);
                db.AddInParameter(dbCommand, "@Gender", DbType.String, _PersonalProfileModel.Gender);
                db.AddInParameter(dbCommand, "@Email", DbType.String, _PersonalProfileModel.Email);
                db.AddInParameter(dbCommand, "@Mobile_number", DbType.String, _PersonalProfileModel.Mobile_number);
                db.AddInParameter(dbCommand, "@Image_url", DbType.String, _PersonalProfileModel.Image_url);
                int ret=db.ExecuteNonQuery(dbCommand);
                if (ret > 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                string var = ex.Message;
            }
            return result;
        }

        //For creating new project details
        public static int NewProjects(ProjectsModel _ProjectsModel)
        {
            int Project_id = 0;
            try
            {
                if (_ProjectsModel != null)
                {
                    Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
                    DbCommand dbCommand = db.GetStoredProcCommand("sp_Projects_ins");
                    db.AddInParameter(dbCommand, "@Project_parent_id", DbType.String, _ProjectsModel.Project_parent_id);
                    db.AddInParameter(dbCommand, "@Project_name", DbType.String, _ProjectsModel.Project_name);
                    db.AddInParameter(dbCommand, "@Project_description", DbType.String, _ProjectsModel.Project_description);
                    db.AddInParameter(dbCommand, "@Project_start_date", DbType.String, _ProjectsModel.Project_start_date);
                    db.AddInParameter(dbCommand, "@Project_end_date", DbType.String, _ProjectsModel.Project_end_date);
                    db.AddInParameter(dbCommand, "@Created_by", DbType.String, _ProjectsModel.Created_by);
                    db.AddInParameter(dbCommand, "@Created_date", DbType.String, _ProjectsModel.Created_date);
                    db.AddInParameter(dbCommand, "@Client_name", DbType.String, _ProjectsModel.Client_name);
                    db.AddInParameter(dbCommand, "@Active_flag", DbType.String, _ProjectsModel.Active_flag);
                    Project_id = (int)db.ExecuteScalar(dbCommand);


                }
            }
            catch (Exception ex)
            {
                string var = ex.Message;
            }
            return Project_id;
        }

        //For get project list
        public static List<ProjectsModel> GetProject(int id)
        {
            ProjectsModel _ProjectsModel = null;
            List<ProjectsModel> ProjectsModelList = new List<ProjectsModel>();
            Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_Project_get");
            if (id > 0)
            {
                db.AddInParameter(dbCommand, "@Employee_profile_id", DbType.Int32, id);
            }
            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader != null && dataReader.Read())
                {
                    _ProjectsModel = new ProjectsModel();
                    _ProjectsModel.Project_id = DataParser.GetSafeInt(dataReader, "Project_id", 0);
                    _ProjectsModel.Project_parent_id = DataParser.GetSafeInt(dataReader, "Project_parent_id", 0);
                    _ProjectsModel.Project_name = DataParser.GetSafeString(dataReader, "Project_name", string.Empty);
                    _ProjectsModel.Project_description = DataParser.GetSafeString(dataReader, "Project_description", string.Empty);
                    _ProjectsModel.Project_start_date = DataParser.GetSafeDateTime(dataReader, "Project_start_date", DateTime.Now);
                    _ProjectsModel.Project_end_date = DataParser.GetSafeDateTime(dataReader, "Project_end_date", DateTime.Now);
                    _ProjectsModel.Created_by = DataParser.GetSafeInt(dataReader, "Created_by", 0);
                    _ProjectsModel.Created_date = DataParser.GetSafeDateTime(dataReader, "Created_date", DateTime.Now);
                    _ProjectsModel.Client_name = DataParser.GetSafeString(dataReader, "Client_name", string.Empty);
                    _ProjectsModel.Active_flag = DataParser.GetSafeBool(dataReader, "Active_flag", true);
                    ProjectsModelList.Add(_ProjectsModel);
                }
            }
            return ProjectsModelList;
        }

        //For updating project details
        public static bool UpdateProject(ProjectsModel _ProjectsModel)
        {
            bool result = false;
            Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_Projects_upd");
            db.AddInParameter(dbCommand, "@Project_parent_id", DbType.String, _ProjectsModel.Project_parent_id);
            db.AddInParameter(dbCommand, "@Project_name", DbType.String, _ProjectsModel.Project_name);
            db.AddInParameter(dbCommand, "@Project_description", DbType.String, _ProjectsModel.Project_description);
            db.AddInParameter(dbCommand, "@Project_start_date", DbType.String, _ProjectsModel.Project_start_date);
            db.AddInParameter(dbCommand, "@Project_end_date", DbType.String, _ProjectsModel.Project_end_date);
            db.AddInParameter(dbCommand, "@Created_by", DbType.String, _ProjectsModel.Created_by);
            db.AddInParameter(dbCommand, "@Created_date", DbType.String, _ProjectsModel.Created_date);
            db.AddInParameter(dbCommand, "@Client_name", DbType.String, _ProjectsModel.Client_name);
            int ret = db.ExecuteNonQuery(dbCommand);
            if (ret > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;

        }
        public static List<EmployeeOfficialModel> GetEmployeeOfficial(int id)
        {
            EmployeeOfficialModel _EmployeeOfficialProfile = null;
            List<EmployeeOfficialModel> officialList = new List<EmployeeOfficialModel>();

            Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_Employee_Official_Profile_get");

            if (id > 0)
            {
                db.AddInParameter(dbCommand, "Employee_official_profile_id", DbType.Int32,id);
            }

            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {
                while (dataReader != null && dataReader.Read())
                {
                    _EmployeeOfficialProfile = new EmployeeOfficialModel();
                    _EmployeeOfficialProfile.Employee_official_profile_id = DataParser.GetSafeInt(dataReader, "Employee_official_profile_id", 0);
                    _EmployeeOfficialProfile.Employee_id = DataParser.GetSafeString(dataReader, "Employee_id", String.Empty);
                    _EmployeeOfficialProfile.Employee_type_id = DataParser.GetSafeInt(dataReader, "Employee_type_id", 0);
                    _EmployeeOfficialProfile.Employee_Type_name = DataParser.GetSafeString(dataReader, "Employee_Type_name", String.Empty);
                    _EmployeeOfficialProfile.Employee_role_id = DataParser.GetSafeInt(dataReader, "Employee_role_id", 0);
                    _EmployeeOfficialProfile.Role_name = DataParser.GetSafeString(dataReader, "Role_name", String.Empty);
                    _EmployeeOfficialProfile.Department_Id = DataParser.GetSafeInt(dataReader, "Department_Id", 0);
                    _EmployeeOfficialProfile.Department_name = DataParser.GetSafeString(dataReader, "Department_name", String.Empty);
                    _EmployeeOfficialProfile.Organization_unit_id = DataParser.GetSafeInt(dataReader, "Organization_unit_id", 0);
                    _EmployeeOfficialProfile.Organization_unit_name = DataParser.GetSafeString(dataReader, "Organization_unit_name", String.Empty);
                    _EmployeeOfficialProfile.Job_code = DataParser.GetSafeString(dataReader, "Job_code", String.Empty);
                    _EmployeeOfficialProfile.Manager = DataParser.GetSafeInt(dataReader, "Manager", 0);
                    _EmployeeOfficialProfile.Manager_Name = DataParser.GetSafeString(dataReader, "Manager_Name", String.Empty);
                    _EmployeeOfficialProfile.Hiring_manager = DataParser.GetSafeInt(dataReader, "Hiring_manager", 0);
                    _EmployeeOfficialProfile.Hiring_Manager_Name = DataParser.GetSafeString(dataReader, "Hiring_Manager_Name", String.Empty);
                    _EmployeeOfficialProfile.Supervisor = DataParser.GetSafeInt(dataReader, "Supervisor", 0);
                    _EmployeeOfficialProfile.supervisor_Name = DataParser.GetSafeString(dataReader, "supervisor_Name", String.Empty);
                    _EmployeeOfficialProfile.Hr_manager = DataParser.GetSafeInt(dataReader, "Hr_manager", 0);
                    _EmployeeOfficialProfile.HR_Manager_Name = DataParser.GetSafeString(dataReader, "HR_Manager_Name", String.Empty);
                    _EmployeeOfficialProfile.Hiring_date = DataParser.GetSafeDateTime(dataReader, "Hiring_date", DateTime.Now);
                    _EmployeeOfficialProfile.Email_address = DataParser.GetSafeString(dataReader, "Email_address", String.Empty);
                    _EmployeeOfficialProfile.Employee_proile_id = DataParser.GetSafeInt(dataReader, "Employee_profile_id", 0);
                    _EmployeeOfficialProfile.Created_by = DataParser.GetSafeInt(dataReader, "Created_by", 0);
                    _EmployeeOfficialProfile.Created_Date = DataParser.GetSafeDateTime(dataReader, "  Created_Date", DateTime.Now);
                    _EmployeeOfficialProfile.Last_updated_by = DataParser.GetSafeInt(dataReader, "Last_updated_by", 0);
                    _EmployeeOfficialProfile.Last_updated_date = DataParser.GetSafeDateTime(dataReader, "Last_updated_date", DateTime.Now);
                    officialList.Add(_EmployeeOfficialProfile);

                }
            }
            return officialList;
        }

        public static bool InsertEmployeeOfficial(EmployeeOfficialModel _EmployeeOfficialModel)
        {
            bool result = false;
            try
            {
                if (_EmployeeOfficialModel == null)
                {
                    result = false;
                }
                Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
                DbCommand dbCommand = db.GetStoredProcCommand("sp_Employee_Official_Profile_ins");
                db.AddInParameter(dbCommand, "@Employee_id", DbType.String, _EmployeeOfficialModel.Employee_id);
                db.AddInParameter(dbCommand, "@Employee_type_id", DbType.Int32, _EmployeeOfficialModel.Employee_type_id);
                db.AddInParameter(dbCommand, "@Employee_role_id", DbType.Int32, _EmployeeOfficialModel.Employee_role_id);
                db.AddInParameter(dbCommand, "@Department_Id", DbType.Int32, _EmployeeOfficialModel.Department_Id);
                db.AddInParameter(dbCommand, "@Organization_unit_id", DbType.Int32, _EmployeeOfficialModel.Organization_unit_id);
                db.AddInParameter(dbCommand, "@Job_code", DbType.String, _EmployeeOfficialModel.Job_code);
                if(_EmployeeOfficialModel.Manager>0)
                db.AddInParameter(dbCommand, "@Manager", DbType.Int32, _EmployeeOfficialModel.Manager);
                if (_EmployeeOfficialModel.Hiring_manager > 0)
                    db.AddInParameter(dbCommand, "@Hiring_manager", DbType.Int32, _EmployeeOfficialModel.Hiring_manager);
                if (_EmployeeOfficialModel.Supervisor > 0)
                    db.AddInParameter(dbCommand, "@Supervisor", DbType.Int32, _EmployeeOfficialModel.Supervisor);
                if (_EmployeeOfficialModel.Hr_manager > 0)
                    db.AddInParameter(dbCommand, "@Hr_manager", DbType.Int32, _EmployeeOfficialModel.Hr_manager);

                db.AddInParameter(dbCommand, "@Hiring_date", DbType.DateTime, _EmployeeOfficialModel.Hiring_date);
                db.AddInParameter(dbCommand, "@Email_address", DbType.String, _EmployeeOfficialModel.Email_address);
                db.AddInParameter(dbCommand, "@Employee_proile_id", DbType.Int32, _EmployeeOfficialModel.Employee_proile_id);
                if (_EmployeeOfficialModel.Created_by > 0)
                    db.AddInParameter(dbCommand, "@Created_by", DbType.Int32, _EmployeeOfficialModel.Created_by);
                if (_EmployeeOfficialModel.Last_updated_by > 0)
                db.AddInParameter(dbCommand, "@Last_updated_by", DbType.Int32, _EmployeeOfficialModel.Last_updated_by);
                db.AddInParameter(dbCommand, "@Active_flag", DbType.Boolean, _EmployeeOfficialModel.Active_flag);
               int ret=db.ExecuteNonQuery(dbCommand);
                if(ret>0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                
            }
            catch (Exception ex)
            {
                string var = ex.Message;
           
            }
            return result;
        }
        public static bool UpdateEmployeeOfficial(EmployeeOfficialModel _EmployeeOfficialModel)
        {
            bool result = true;
            try
            {
                Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
                DbCommand dbCommand = db.GetStoredProcCommand("sp_Employee_Official_Profile_update");
                db.AddInParameter(dbCommand, "@Employee_official_profile_id", DbType.Int32, _EmployeeOfficialModel.Employee_official_profile_id);
                db.AddInParameter(dbCommand, "@Employee_id", DbType.String, _EmployeeOfficialModel.Employee_id);
                db.AddInParameter(dbCommand, "@Employee_type_id", DbType.Int32, _EmployeeOfficialModel.Employee_type_id);
                db.AddInParameter(dbCommand, "@Employee_role_id", DbType.Int32, _EmployeeOfficialModel.Employee_role_id);
                db.AddInParameter(dbCommand, "@Department_Id", DbType.Int32, _EmployeeOfficialModel.Department_Id);
                db.AddInParameter(dbCommand, "@Organization_unit_id", DbType.Int32, _EmployeeOfficialModel.Organization_unit_id);
                db.AddInParameter(dbCommand, "@Job_code", DbType.String, _EmployeeOfficialModel.Job_code);
                db.AddInParameter(dbCommand, "@Manager", DbType.Int32, _EmployeeOfficialModel.Manager);
                db.AddInParameter(dbCommand, "@Hiring_manager", DbType.Int32, _EmployeeOfficialModel.Hiring_manager);
                db.AddInParameter(dbCommand, "@Supervisor", DbType.Int32, _EmployeeOfficialModel.Supervisor);
                db.AddInParameter(dbCommand, "@Hr_manager", DbType.Int32, _EmployeeOfficialModel.Hr_manager);
                db.AddInParameter(dbCommand, "@Hiring_date", DbType.DateTime, _EmployeeOfficialModel.Hiring_date);
                db.AddInParameter(dbCommand, "@Email_address", DbType.String, _EmployeeOfficialModel.Email_address);
                db.AddInParameter(dbCommand, "@Employee_proile_id", DbType.Int32, _EmployeeOfficialModel.Employee_proile_id);
              
               int ret= db.ExecuteNonQuery(dbCommand);
                if(ret>0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
               
            }
            catch (Exception ex)
            {
                string var = ex.Message;
                throw;
            }
            return result;

        }
        public static List<EmployeeRole> GetEmployeeRole()
        {
            EmployeeRole _EmployeeRole = new EmployeeRole();
            List<EmployeeRole> roleList = new List<EmployeeRole>();
            Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_Employee_Role_get");

            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {

                while (dataReader != null && dataReader.Read())
                {
                    _EmployeeRole = new EmployeeRole();
                    _EmployeeRole.Employee_role_id= DataParser.GetSafeInt(dataReader, "Employee_role_id", 0);
                    _EmployeeRole.Role_name = DataParser.GetSafeString(dataReader, "Role_name", String.Empty);
                    roleList.Add(_EmployeeRole);

                }
            }
            return roleList;
        }

        public static List<EmployeeType> GetEmployeeType()
        {
            EmployeeType _EmployeeType = new EmployeeType();
            List<EmployeeType> typeList = new List<EmployeeType>();
            Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_Employee_Type_get");

            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {

                while (dataReader != null && dataReader.Read())
                {
                    _EmployeeType = new EmployeeType();
                    _EmployeeType.Employee_Type_Id = DataParser.GetSafeInt(dataReader, "Employee_Type_Id", 0);
                    _EmployeeType.Employee_Type_name= DataParser.GetSafeString(dataReader, "Employee_Type_name", String.Empty);
                    typeList.Add(_EmployeeType);

                }
            }
            return typeList;
        }
        public static List<Department> GetDepartment()
        {
            Department _Department = new Department();
            List<Department> departmentList = new List<Department>();
            Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_Department_get");

            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {

                while (dataReader != null && dataReader.Read())
                {
                    _Department = new Department();
                    _Department.Department_Id= DataParser.GetSafeInt(dataReader, "Department_Id", 0);
                    _Department.Department_name = DataParser.GetSafeString(dataReader, "Department_name", String.Empty);
                    departmentList.Add(_Department);

                }
            }
            return departmentList;
        }

        public static List<OrganizationUnit> GetOrganizationUnit()
        {
            OrganizationUnit _OrganizationUnit = new OrganizationUnit();
            List<OrganizationUnit> departmentList = new List<OrganizationUnit>();
            Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_Organization_unit_get");

            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {

                while (dataReader != null && dataReader.Read())
                {
                    _OrganizationUnit = new OrganizationUnit();
                    _OrganizationUnit.Organization_unit_id = DataParser.GetSafeInt(dataReader, "Organization_unit_id", 0);
                    _OrganizationUnit.Organization_unit_name = DataParser.GetSafeString(dataReader, "Organization_unit_name", String.Empty);
                    departmentList.Add(_OrganizationUnit);

                }
            }
            return departmentList;
        }

        public static List<PersonalProfileModel> GetManager()
        {
            PersonalProfileModel _PersonalProfileModel = new PersonalProfileModel();
            List<PersonalProfileModel> mangerList = new List<PersonalProfileModel>();

            Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_Manager_get");

            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {

                while (dataReader != null && dataReader.Read())
                {
                    _PersonalProfileModel = new PersonalProfileModel();

                    _PersonalProfileModel.Employee_profile_id  = DataParser.GetSafeInt(dataReader, "Employee_profile_id", 0);
                    _PersonalProfileModel.Employee_name= DataParser.GetSafeString(dataReader, "Employee_name", String.Empty);
                    mangerList.Add(_PersonalProfileModel);

                }
            }
            return mangerList;

        }
        public static List<PersonalProfileModel> GetSupervisor()
        {
            PersonalProfileModel _PersonalProfileModel = new PersonalProfileModel();
            List<PersonalProfileModel> supervisorList = new List<PersonalProfileModel>();

            Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_Supervisor_get");

            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {

                while (dataReader != null && dataReader.Read())
                {
                    _PersonalProfileModel = new PersonalProfileModel();

                    _PersonalProfileModel.Employee_profile_id = DataParser.GetSafeInt(dataReader, "Employee_profile_id", 0);
                    _PersonalProfileModel.Employee_name = DataParser.GetSafeString(dataReader, "Employee_name", String.Empty);
                    supervisorList.Add(_PersonalProfileModel);

                }
            }
            return supervisorList;

        }

        public static List<PersonalProfileModel> GetHiringManager()
        {
            PersonalProfileModel _PersonalProfileModel = new PersonalProfileModel();
            List<PersonalProfileModel> hiringManagerList = new List<PersonalProfileModel>();

            Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_HiringManager_get");

            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {

                while (dataReader != null && dataReader.Read())
                {
                    _PersonalProfileModel = new PersonalProfileModel();

                    _PersonalProfileModel.Employee_profile_id = DataParser.GetSafeInt(dataReader, "Employee_profile_id", 0);
                    _PersonalProfileModel.Employee_name = DataParser.GetSafeString(dataReader, "Employee_name", String.Empty);
                    hiringManagerList.Add(_PersonalProfileModel);

                }
            }
            return hiringManagerList;

        }
        public static List<PersonalProfileModel> GetHRManager()
        {
            PersonalProfileModel _PersonalProfileModel = new PersonalProfileModel();
            List<PersonalProfileModel> hrManagerList = new List<PersonalProfileModel>();

            Database db = DatabaseFactory.CreateDatabase("Helios_V2_DB");
            DbCommand dbCommand = db.GetStoredProcCommand("sp_HRManager_get");

            using (IDataReader dataReader = db.ExecuteReader(dbCommand))
            {

                while (dataReader != null && dataReader.Read())
                {
                    _PersonalProfileModel = new PersonalProfileModel();

                    _PersonalProfileModel.Employee_profile_id = DataParser.GetSafeInt(dataReader, "Employee_profile_id", 0);
                    _PersonalProfileModel.Employee_name = DataParser.GetSafeString(dataReader, "Employee_name", String.Empty);
                    hrManagerList.Add(_PersonalProfileModel);

                }
            }
            return hrManagerList;

        }
    }
}
    