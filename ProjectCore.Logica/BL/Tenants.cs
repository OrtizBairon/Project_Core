using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectCore.Logica.BL
{
    public class Tenants
    {
        public List<Models.BD.Tenants> GetTenants(string userId)
        {

            Project_Core.DAL.Models.Project_CoreContext _Context = new Project_Core.DAL.Models.Project_CoreContext();

            var listTenants = (from _tenants in _Context.Tenants
                               join _aspNetUsers in _Context.AspNetUsers on _tenants.Id equals _aspNetUsers.TenantId
                               where _aspNetUsers.Id.Equals(userId)
                               select new Models.BD.Tenants
                               {
                                   Id = _tenants.Id,
                                   Name = _tenants.Name,
                                   Plan = _tenants.Plan,
                                   UpdatedAt = _tenants.UpdatedAt,
                                   CreatedAt = _tenants.CreatedAt,

                               }).ToList();

            return listTenants;
        }
    }
}
