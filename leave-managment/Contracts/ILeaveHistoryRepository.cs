﻿using leave_managment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_managment.Contracts
{
    interface ILeaveHistoryRepository : IRepositoryBase<LeaveHistory>
    {
    }
}
