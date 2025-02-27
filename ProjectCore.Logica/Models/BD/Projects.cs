﻿using Project_Core.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace ProjectCore.Logica.Models.BD
{
   public class Projects 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime? ExpectedCompletionDate { get; set; }
        public int? TenantId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual Tenants Tenant { get; set; }
    }
}
