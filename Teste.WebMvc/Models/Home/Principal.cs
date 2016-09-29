using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste.WebMvc.Models.Home
{
    public class Principal
    {
        public string Token { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public List<Produto> Produtos { get; set; }
        public string ErrorMessage { get; set; }
    }
}