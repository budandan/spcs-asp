using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SPCS.Models;
using SPCS.DAL;
using System.Web.Security;

namespace SPCS.App_Start
{
    public class SPCSRoleProvider : RoleProvider
    {
        private SPCSContext db = new SPCSContext();
        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            string[] role = new string[] { };
            Staff s = db.Staffs.Find(Int32.Parse(username));

            if (s != null)
            {
                if (s.Role == "Admin")
                {
                    return new string[] { "Admin" };
                }
                else if (s.Role == "Manager")
                {
                    return new string[] { "Manager" };
                }
                else if (s.Role == "Staff")
                {
                    return new string[] { "Staff" };
                }
            }
            return new string[] { "" };
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}