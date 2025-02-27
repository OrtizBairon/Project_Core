﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectCore.Logica.Models.ViewModel
{
    //controlador accion y lo que especifica
    public class ProjectsIndexViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Details")]
        public string Details { get; set; }

        [Display(Name = "ExpectedCompletionDate")]
        public DateTime? ExpectedCompletionDate { get; set; }

        [Display(Name = "CreatedAt")]
        public DateTime? CreatedAt { get; set; }

        [Display(Name = "UpdatedAt")]
        public DateTime? UpdatedAt { get; set; }
    }

    public class ProjectsDetailsViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Details")]
        public string Details { get; set; }

        [Display(Name = "ExpectedCompletionDate")]
        public DateTime? ExpectedCompletionDate { get; set; }

        [Display(Name = "CreatedAt")]
        public DateTime? CreatedAt { get; set; }

        [Display(Name = "UpdatedAt")]
        public DateTime? UpdatedAt { get; set; }
    }
}
