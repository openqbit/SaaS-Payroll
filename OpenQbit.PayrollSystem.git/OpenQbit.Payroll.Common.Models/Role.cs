﻿using OpenQbit.Payroll.Common.Models.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Payroll.Common.Models
{
    public class Role
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
        public virtual Systems System { get; set; }
    }
}
