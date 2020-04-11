using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectCore.Logica.BL
{
    public class States
    {
        public List<Models.BD.States> GetStates()
        {
            Project_Core.DAL.Models.Project_CoreContext _Context = new Project_Core.DAL.Models.Project_CoreContext();


            var listStates = (from _states in _Context.States
                                  where _states.Active == true
                                  select new Models.BD.States
                                  {
                                      Id = _states.Id,
                                      Name = _states.Name,
                                      Active = _states.Active

                                  }).ToList();
            return listStates;
        }
    }
}
