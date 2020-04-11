using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Project_Core.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index(int? projectId)
        {

            ProjectCore.Logica.BL.Tasks tasks = new ProjectCore.Logica.BL.Tasks();
            var listTasks = tasks.GetTasks(projectId, null);

            var listTasksViewModel = listTasks.Select(x => new ProjectCore.Logica.Models.ViewModel.TasksIndexViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Details = x.Details,
                ExpirationDate = x.ExpirationDate,
                IsCompleted = x.IsCompleted,
                Effort = x.Effort,
                RemainingWork = x.RemainingWork,
                State = x.States.Name,
                Activity = x.Activities.Name,
                Priority = x.Priorities.Name
            });

            ProjectCore.Logica.BL.Projects projects = new ProjectCore.Logica.BL.Projects();

            var project = projects.GetProjects(projectId, null).FirstOrDefault();

            ViewBag.project = project; //>para enviar datos de una acción a la vista Solo se puede utilizar en esta ocación
            return View(listTasksViewModel);
        }

        public IActionResult Create(int? projectId)
        {
            var taskBindingModel = new ProjectCore.Logica.Models.BindingModel.TasksCreateBindingModel
            {
                ProjectId = projectId
            };

            ProjectCore.Logica.BL.Activities activities = new ProjectCore.Logica.BL.Activities();
            ViewBag.Activities = activities.GetActivities();

            ProjectCore.Logica.BL.Priorities priorities = new ProjectCore.Logica.BL.Priorities();
            ViewBag.Priorities = priorities.GetPriorities();

            ProjectCore.Logica.BL.States states = new ProjectCore.Logica.BL.States();
            ViewBag.States = states.GetStates();

            return View(taskBindingModel);
        }
        [HttpPost]
        public IActionResult Create(ProjectCore.Logica.Models.BindingModel.TasksCreateBindingModel model) {

            if (ModelState.IsValid)
            {

                ProjectCore.Logica.BL.Tasks tasks = new ProjectCore.Logica.BL.Tasks();
                tasks.CreateTasks(model.Title,
                    model.Details,
                    model.ExpirationDate,
                    model.IsCompleted,
                    model.Effort,
                    model.RemainingWork,
                    model.StateId,
                    model.ActivityId,
                    model.PriorityId,
                    model.ProjectId);

                return RedirectToAction("Index", new { projectId = model.ProjectId});
            }

            ProjectCore.Logica.BL.Activities activities = new ProjectCore.Logica.BL.Activities();
            ViewBag.Activities = activities.GetActivities();

            ProjectCore.Logica.BL.Priorities priorities = new ProjectCore.Logica.BL.Priorities();
            ViewBag.Priorities = priorities.GetPriorities();

            ProjectCore.Logica.BL.States states = new ProjectCore.Logica.BL.States();
            ViewBag.States = states.GetStates();

            return View(model);
        }
    }
}