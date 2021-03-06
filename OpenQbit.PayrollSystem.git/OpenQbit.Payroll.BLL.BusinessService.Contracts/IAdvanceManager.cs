﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Payroll.Common.Models;

namespace OpenQbit.Payroll.BLL.BusinessService.Contracts
{
    public interface IAdvanceManager
    {
        bool RecordAdvance(Advance advance);
        bool EditAdvance(Advance advance);
        bool RemoveAdvance(Advance advance);
        List<Advance> GetAllAdvances();
        Advance FindAdvance(Advance advance);

    }


}
