using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CotacaoBLL
    {
        public List<Cotacao> ObterCotacao(string titulo, int id)
        {
            try
            {
                //http://www.anbima.com.br/merc_sec/arqs/ms170529.txt
                WebClient client = new WebClient();
                Stream stream = client.OpenRead("http://www.anbima.com.br/merc_sec/arqs/ms" + id + ".txt");
                StreamReader reader = new StreamReader(stream);
                String content = reader.ReadToEnd();

                string[] str = content.Split(new string[] { Environment.NewLine },
                                                       StringSplitOptions.None);
                List<Cotacao> lst = new List<Cotacao>();

                for (int i = 0; i < str.Length; i++)
                {
                    string[] s = str[i].Split('@');
                    Cotacao c = new Cotacao();
                    if (s[0] == titulo)
                    {
                        c.Titulo = s[0];
                        c.DataVencimento = s[4];
                        c.TaxasIndicativas = double.Parse(s[7]);
                        lst.Add(c);
                    }
                }




                return lst;
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
