using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiTeste.Models;


namespace WebApiTeste.Controllers
{
    public class CotacaoController : ApiController
    {

       


        // GET api/cotacao
        public string Get()
        {
            return "OK";
        }

        // GET api/cotacao/5
        public BLL.Cotacao[] Get(int id)
        {
            List<BLL.Cotacao> lst = new List<BLL.Cotacao>();
            BLL.CotacaoBLL bll = new BLL.CotacaoBLL();
            lst = bll.ObterCotacao("LTN", id);

            return lst.ToArray();
        }

        // POST api/cotacao
        public void Post([FromBody]string value)
        {
        }

        // PUT api/cotacao/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/cotacao/5
        public void Delete(int id)
        {
        }
    }
}
