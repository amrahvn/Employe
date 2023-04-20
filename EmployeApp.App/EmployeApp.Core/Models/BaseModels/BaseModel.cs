﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeApp.Core.Models.BaseModels
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime Updated { get; set; }

    }
}
