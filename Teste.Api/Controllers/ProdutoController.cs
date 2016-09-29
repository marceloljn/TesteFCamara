using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Teste.Api.Models;

namespace Teste.Api.Controllers
{
    public class ProdutoController : ApiController
    {
        // GET api/produto
        public IEnumerable<tb_produto> GetProducts(string token)
        {
            var client = new Validation.ValidationClient();

            var result = client.ValidateToken(token);

            if (!result)
                throw new ApplicationException("Token inválido ou expirado.");

            using (var db = new TesteEntities())
            {
                var lista = db.tb_produto.ToList();
                return lista;
            }
        }
    }
}
