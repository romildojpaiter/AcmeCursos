﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFAcme.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProfessorService" in both code and config file together.
    [ServiceContract]
    public interface IProfessorService
    {
        [OperationContract]
        void DoWork();
    }
}
