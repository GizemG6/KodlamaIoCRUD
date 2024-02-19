﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Entities
{
    public class Course : BaseEntity
    {
        public string Description { get; set; }
        public Category Category { get; set; }
        public Instructor Instructor { get; set; }
    }
}
