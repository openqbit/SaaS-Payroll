﻿using OpenQbit.Payroll.Common.Models.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Payroll.Common.Models
{
    public class BonusType
    {
        public int Id { get; set; }
        public int SystemId { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        // test comits
        public virtual ICollection<Bonus> Bonus { get; set; }
        public virtual Systems System { get; set; }
    }
}
