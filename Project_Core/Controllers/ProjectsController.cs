using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace Project_Core.Controllers
{

    [Authorize] //debe de estar logueado o autorizado <-- aqui a nivel general de controlador si se requiere solo las aciones , aplicar en la acción especifica
    public class ProjectsController : Controller
    {
        //private List<ProjectCore.Logica.Models.ViewModel.ProjectsIndexViewModel> ListProjects;
        ////RETORNA UN JSON O UNA VISTA
        //public ProjectsController()
        //{
        //    ListProjects = new List<ProjectCore.Logica.Models.ViewModel.ProjectsIndexViewModel>();

        //    ListProjects.Add(new ProjectCore.Logica.Models.ViewModel.ProjectsIndexViewModel
        //    {
        //        Id = 1,
        //        Details = "Projects Managment Details",
        //        Title = "Projects Managment",
        //        CreatedAt = DateTime.Now,
        //        ExpectedCompletionDate = DateTime.Now.AddDays(5)

        //    });

        //    ListProjects.Add(new ProjectCore.Logica.Models.ViewModel.ProjectsIndexViewModel
        //    {
        //        Id = 2,
        //        Details = "Sales Details",
        //        Title = "Sales",
        //        CreatedAt = DateTime.Now,
        //        ExpectedCompletionDate = DateTime.Now.AddDays(10)

        //    });
        //}

        //[HttpGet]
        private readonly UserManager<IdentityUser> _userManager;

        public ProjectsController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()

        {
            IdentityUser user = await _userManager.FindByIdAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            //ViewBag.listProjects = ListProjects;

            ProjectCore.Logica.BL.Tenants tenants = new ProjectCore.Logica.BL.Tenants();
            var tenant = tenants.GetTenants(user.Id).FirstOrDefault();

            ProjectCore.Logica.BL.Projects projects = new ProjectCore.Logica.BL.Projects();
            var result = await _userManager.IsInRoleAsync(user, "Admin") ? //entonces
                projects.GetProjects(null, tenant.Id) :  //de locontrario
            projects.GetProjects(null, tenant.Id, user.Id);

            var listProjects = result.Select(x => new ProjectCore.Logica.Models.ViewModel.ProjectsIndexViewModel
            {

                Id = x.Id,
                Title = x.Title,
                Details = x.Details,
                CreatedAt = x.CreatedAt,
                ExpectedCompletionDate = x.ExpectedCompletionDate,
                UpdatedAt = x.UpdatedAt
            });

            listProjects = tenant.Plan.Equals("Premium") ?
                listProjects :
                listProjects.Take(2).ToList();
            return View(listProjects); //retorna a la vista que se llame igual que a la acción
        }
        [HttpGet] //CARGA DE VISTA
        public IActionResult Create()
        {

            return View();


        }
        [HttpPost] //ENVIAR DATOS INSERCCIÓN
        public async Task<IActionResult> Create(ProjectCore.Logica.Models.BindingModel.ProjectsCreateBindingModel model)
        {
            if (ModelState.IsValid)
            {

                IdentityUser user = await _userManager.FindByIdAsync(User.FindFirst(ClaimTypes.NameIdentifier).Value);
                //ViewBag.listProjects = ListProjects;

                ProjectCore.Logica.BL.Tenants tenants = new ProjectCore.Logica.BL.Tenants();
                var tenant = tenants.GetTenants(user.Id).FirstOrDefault();

                ProjectCore.Logica.BL.Projects projects = new ProjectCore.Logica.BL.Projects();
                projects.CreateProjects(model.Title,
                    model.Details,
                    model.ExpectedCompletionDate,
                    tenant.Id);

                return RedirectToAction("Index");

            }
            return View(model);


        }

        public IActionResult Edit(int? id)
        {
            ProjectCore.Logica.BL.Projects projects = new ProjectCore.Logica.BL.Projects();
            var project = projects.GetProjects(id, null).FirstOrDefault();

            var projectBindingModel = new ProjectCore.Logica.Models.BindingModel.ProjectsEditBindingModel
            {
                Id = project.Id,
                Details = project.Details,
                Title = project.Title,
                ExpectedCompletionDate = project.ExpectedCompletionDate,


            };

            return View(projectBindingModel);
        }

        [HttpPost]

        public IActionResult Edit(ProjectCore.Logica.Models.BindingModel.ProjectsEditBindingModel model)
        {
            if (ModelState.IsValid)
            {


                ProjectCore.Logica.BL.Projects projects = new ProjectCore.Logica.BL.Projects();
                projects.UpdateProjects(model.Id,
                    model.Title,
                    model.Details,
                    model.ExpectedCompletionDate);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Details(int? id)
        {

            ProjectCore.Logica.BL.Projects projects = new ProjectCore.Logica.BL.Projects();
            var project = projects.GetProjects(id, null).FirstOrDefault();

            var projectViewModel = new ProjectCore.Logica.Models.ViewModel.ProjectsDetailsViewModel
            {
                Id = project.Id,
                Details = project.Details,
                Title = project.Title,
                ExpectedCompletionDate = project.ExpectedCompletionDate,
                CreatedAt = project.CreatedAt,
                UpdatedAt = project.UpdatedAt

            };

            return View(projectViewModel);

        }


        public IActionResult Delete(int id)
        {

            ProjectCore.Logica.BL.Projects projects = new ProjectCore.Logica.BL.Projects();
            projects.DeleteProjects(id);

            return RedirectToAction("Index"); //--> puedo redireccionar a acciones de otros controladores 

        }
    }

}