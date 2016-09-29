using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Teste.Wcf.Model;

namespace Teste.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Validation" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Validation.svc or Validation.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    public class Validation : IValidation
    {
        private List<Token> tokenList = new List<Token>();

        public Token GenerateToken()
        {
            var newToken = new Token();
            newToken.ExpirationDate = DateTime.Now.AddMinutes(1);
            newToken.Value = Guid.NewGuid().ToString();

            tokenList.Add(newToken);

            return newToken;
        }

        public bool ValidateToken(string tokenValue)
        {
            var token = tokenList.FirstOrDefault(x => x.Value == tokenValue);

            if (token == null)
            {
                return false;
            }

            if (token.ExpirationDate < DateTime.Now)
            {
                tokenList.Remove(token);
                return false;
            }

            return true;
        }
    }
}
