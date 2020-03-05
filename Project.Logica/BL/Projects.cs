using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Logica.BL
{
    class Projects
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime? ExpectedCompletionDate { get; set; }
        public int? TenantId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }


    }
}
