﻿using BookReadingEvent1.Basic1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace BookReadingEvent1.Authorization
{
    public class RoleProvider
    {
        public class ApplicationRoleProvider : RoleProvider
        {
            public override string ApplicationName { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

            public override void AddUsersToRoles(string[] usernames, string[] roleNames)
            {
                throw new System.NotImplementedException();
            }

            public override void CreateRole(string roleName)
            {
                throw new System.NotImplementedException();
            }

            public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
            {
                throw new System.NotImplementedException();
            }

            public override string[] FindUsersInRole(string roleName, string usernameToMatch)
            {
                throw new System.NotImplementedException();
            }

            public override string[] GetAllRoles()
            {
                throw new System.NotImplementedException();
            }

            public override string[] GetRolesForUser(string userName)
            {
                return new UserRole1().GetRoles(userName);
            }

            public override string[] GetUsersInRole(string roleName)
            {
                throw new System.NotImplementedException();
            }

            public override bool IsUserInRole(string username, string roleName)
            {
                throw new System.NotImplementedException();
            }

            public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
            {
                throw new System.NotImplementedException();
            }

            public override bool RoleExists(string roleName)
            {
                throw new System.NotImplementedException();
            }

        }
    }
}