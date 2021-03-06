﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Teste.Wcf.Model;

namespace Teste.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IValidation" in both code and config file together.
    [ServiceContract]
    public interface IValidation
    {
        [OperationContract]
        Token GenerateToken();

        [OperationContract]
        bool ValidateToken(string tokenValue);
    }
}
