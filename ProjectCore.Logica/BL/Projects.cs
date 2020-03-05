using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ProjectCore.Logica.Models.BD;

namespace ProjectCore.Logica.BL
{
    public class Projects
    {


        public List<Models.BD.Projects> GetProjects(int? id, int? tenantId, string userId = null)
        {
            Project_Core.DAL.Models.Project_CoreContext _Context = new Project_Core.DAL.Models.Project_CoreContext();


            var listProjectsEF = (from _projects in _Context.Projects
                                  select _projects).ToList();

            if (id != null)
                listProjectsEF = listProjectsEF.Where(x => x.Id == id).ToList();
            if (tenantId != null)
                listProjectsEF = listProjectsEF.Where(x => x.TenantId == tenantId).ToList();
            if (!string.IsNullOrEmpty(userId))
                listProjectsEF = (from _projects in listProjectsEF
                                  join _userProjects in _Context.UserProjects on _projects.Id equals _userProjects.ProjectId
                                  where _userProjects.UserId.Equals(userId)
                                  select _projects).ToList();

            var listProjects = (from _projects in listProjectsEF
                                select new Models.BD.Projects
                                {
                                    Id = _projects.Id,
                                    Title = _projects.Title,
                                    Details = _projects.Details,
                                    ExpectedCompletionDate = _projects.ExpectedCompletionDate,
                                    TenantId = _projects.TenantId,
                                    CreatedAt = _projects.CreatedAt,
                                    UpdatedAt = _projects.UpdatedAt

                                }).ToList();
            return listProjects;

        }

        public void CreateProjects(string title,
            string details,
            DateTime? expectedCompletionDate, int? tenantId)
        {

            Project_Core.DAL.Models.Project_CoreContext _Context = new Project_Core.DAL.Models.Project_CoreContext();

            _Context.Projects.Add(new Project_Core.DAL.Models.Projects
            {

                Title = title,
                Details = details,
                ExpectedCompletionDate = expectedCompletionDate,
                TenantId = tenantId,
                CreatedAt = DateTime.Now
               // UpdatedAt = DateTime.Now

            });

            _Context.SaveChanges();

        }
    }
}
