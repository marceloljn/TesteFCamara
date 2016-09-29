using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste.Wcf.Model
{
    public class Token
    {
        public string Value { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}