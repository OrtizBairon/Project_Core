﻿using System;
using System.Collections.Generic;

namespace Project_Core.DAL.Models
{
    public partial class Activities
    {
        public Activities()
        {
            Tasks = new HashSet<Tasks>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}
