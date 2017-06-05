using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiTeste.Models
{
    public class Cotacao
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string DataVencimento { get; set; }

        public double TaxasIndicativas { get; set; }




    }
}