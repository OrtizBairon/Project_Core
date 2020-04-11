using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProjectCore.Logica.BL
{
    public class Tasks
    {

        public List<Models.BD.Tasks> GetTasks(int? projectId,
            int? id)
        {

            Project_Core.DAL.Models.Project_CoreContext _Context = new Project_Core.DAL.Models.Project_CoreContext();
            var listTasks = (from _tasks in _Context.Tasks
                             join _states in _Context.States on _tasks.StateId equals _states.Id
                             join _activities in _Context.Activities on _tasks.ActivityId equals _activities.Id
                             join _priorities in _Context.Priorities on _tasks.PriorityId equals _priorities.Id
                             select new Models.BD.Tasks
                             {
                                 Id = _tasks.Id,
                                 Title = _tasks.Title,
                                 Details = _tasks.Details,
                                 ExpirationDate = _tasks.ExpirationDate,
                                 IsCompleted = _tasks.IsCompleted,
                                 Effort = _tasks.Effort,
                                 RemainingWork = _tasks.RemainingWork,
                                 StateId = _tasks.StateId,
                                 States = new Models.BD.States
                                 {
                                     Name = _states.Name

                                 },
                                 PriorityId = _tasks.PriorityId,
                                 Priorities = new Models.BD.Priorities
                                 {
                                     Name = _priorities.Name
                                 },
                                 ActivityId = _tasks.ActivityId,
                                 Activities = new Models.BD.Activities
                                 {
                                     Name = _activities.Name
                                 },
                                 ProjectId = _tasks.ProjectId
                             }).ToList();


            if (projectId != null)

                listTasks = listTasks.Where(x => x.ProjectId == projectId).ToList();

            if (id != null)

                listTasks = listTasks.Where(x => x.Id == id).ToList();

            return listTasks;
        }

        public void CreateTasks(string title,
            string details,
            DateTime? expirationDate,
            bool? isCompleted,
            int? effort,
            int? remainingWork,
            int? stateId,
            int? activityId,
            int? priorityId,
            int? projectId)
        {

            Project_Core.DAL.Models.Project_CoreContext _Context = new Project_Core.DAL.Models.Project_CoreContext();

            _Context.Tasks.Add(new Project_Core.DAL.Models.Tasks
            {

                Title = title,
                Details = details,
                ExpirationDate = expirationDate,
                IsCompleted = isCompleted,
                Effort = effort,
                RemainingWork = remainingWork,
                StateId = stateId,
                ActivityId = activityId,
                PriorityId = priorityId,
                ProjectId = projectId
            });

            _Context.SaveChanges();

        }
    }
}
