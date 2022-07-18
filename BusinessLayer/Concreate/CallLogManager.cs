﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class CallLogManager:ICallLogService
    {
        ICallLogDal _callLogdal;

        public CallLogManager(ICallLogDal callLogdal)
        {
            _callLogdal = callLogdal;
        }

        public void CallLogAdd(CallLog job)
        {
            throw new NotImplementedException();
        }

        public void CallLogDelete(CallLog job)
        {
            throw new NotImplementedException();
        }

        public List<CallLog> CallLogList()
        {
            return _callLogdal.GetListAll(x=>x.CallLogStatus==true);
        }

        public void CallLogUpdate(CallLog job)
        {
            throw new NotImplementedException();
        }

        public CallLog GetById(int id)
        {
            return _callLogdal.GetById(id);
        }

        public List<CallLog> GetCallLogListWithCustomer()
        {
            return _callLogdal.GetCallWithCustomer();
        }

        

        
    }
}