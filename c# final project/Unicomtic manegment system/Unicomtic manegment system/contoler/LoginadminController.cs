using System;
using System.Collections.Generic;
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.controller
{
    internal class LoginadminController
    {
        // Simulated data store for example
        private List<Loginadmin> admins;

        public LoginadminController()
        {
            // Initialize with some dummy admin users
            admins = new List<Loginadmin>()
            {
                new Loginadmin("admin", "admin123"),
                new Loginadmin("superuser", "password")
            };
        }

        // Method to validate login credentials
        public bool ValidateLogin(string username, string password)
        {
            foreach (var admin in admins)
            {
                if (admin.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
                    && admin.Password == password)
                {
                    return true;  // Valid login
                }
            }
            return false;  // Invalid login
        }

        // Optionally, add methods to add/remove/update admins if needed
        public void AddAdmin(Loginadmin newAdmin)
        {
            admins.Add(newAdmin);
        }
    }
}
