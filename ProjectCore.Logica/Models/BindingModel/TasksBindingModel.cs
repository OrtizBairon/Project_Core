using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ProjectCore.Logica.Models.BindingModel
{
    public class TasksCreateBindingModel
    {
        [Required(ErrorMessage = "The field title is requerid")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The field Details is requerid")]
        [Display(Name = "Details")]
        public string Details { get; set; }

        [Required(ErrorMessage = "The field Expiration Date is requerid")]
        [Display(Name = "Expiration Date")]
        public DateTime? ExpirationDate { get; set; }

        [Required(ErrorMessage = "The field Is Completed is requerid")]
        [Display(Name = "Is Completed")]
        public bool IsCompleted { get; set; }

        [Required(ErrorMessage = "The field Effort is requerid")]
        [Display(Name = "Effort")]
        public int? Effort { get; set; }

        [Required(ErrorMessage = "The field Remaining Work is requerid")]
        [Display(Name = "Remaining Work")]
        public int? RemainingWork { get; set; }

        [Required(ErrorMessage = "The field State is requerid")]
        [Display(Name = "State")]
        public int? StateId { get; set; }

        [Required(ErrorMessage = "The field Activity is requerid")]
        [Display(Name = "Activity")]
        public int? ActivityId { get; set; }

        [Required(ErrorMessage = "The field Priority is requerid")]
        [Display(Name = "Priority")]
        public int? PriorityId { get; set; }

        public int? ProjectId { get; set; }

    }
}
