using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Teste.WebMvc.Models.Home;

namespace Teste.WebMvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(new Principal());
        }

        [HttpPost]
        public ActionResult Index(Principal model)
        {
            model.ErrorMessage = string.Empty;
            HttpClient client = new HttpClient();
            HttpResponseMessage wcfResponse = client.GetAsync("http://localhost:61607/Api/Produto?token=" + model.Token).Result;
            HttpContent stream = wcfResponse.Content;
            var data = stream.ReadAsStringAsync();

            if (data.Result.Contains("Token inválido ou expirado."))
            {
                model.ErrorMessage = "Token Inválido ou Expirado, favor requisitar novo Token.";
            }
            else
            {
                var json_serializer = new JavaScriptSerializer();
                var produtos = json_serializer.Deserialize<List<Produto>>(data.Result);

                model.Produtos = produtos;
            }

            return View(model);
        }


        [HttpGet]
        public JsonResult GetToken()
        {
            var client = new Validation.ValidationClient();
            return this.Json(client.GenerateToken(), JsonRequestBehavior.AllowGet);
        }
    }
}
