﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSLibrary.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<DepartmentOutcomeModel> Outcomes { get; set; } = new List<DepartmentOutcomeModel>();
    }
}
