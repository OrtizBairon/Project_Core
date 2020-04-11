using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectCore.Logica.BL
{
    public class Priorities
    {
        public List<Models.BD.Priorities> GetPriorities()
        {
            Project_Core.DAL.Models.Project_CoreContext _Context = new Project_Core.DAL.Models.Project_CoreContext();


            var listPriorities = (from _priorities in _Context.Priorities
                                  where _priorities.Active == true
                                  select new Models.BD.Priorities
                                  {
                                      Id = _priorities.Id,
                                      Name = _priorities.Name,
                                      Active = _priorities.Active

                                  }).ToList();
            return listPriorities;
        }
    }
}
