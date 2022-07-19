﻿using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICallLogService
    {
        void CallLogAdd(CallLog job);
        void CallLogDelete(CallLog job);
        void CallLogUpdate(CallLog job);
        List<CallLog> CallLogList();
        CallLog GetById(int id);
        CallLog GetCallWithFilter(Expression<Func<CallLog, bool>> filter);
        List<CallLog> GetCallLogListWithCustomer();
    }
}
