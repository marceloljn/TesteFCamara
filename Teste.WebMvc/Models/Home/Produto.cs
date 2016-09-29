using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste.WebMvc.Models.Home
{
    public class Produto
    {
        public int id_produto { get; set; }
        public string nm_produto { get; set; }
        public string ds_produto { get; set; }
        public decimal vl_produto { get; set; }
    }
}