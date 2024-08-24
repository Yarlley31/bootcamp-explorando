using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcamp_explorando.Models
{

    // tupla em método
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeDeLinhas) LerArquivo(string caminho)
        {
            try{
                string[] linhas = File.ReadAllLines(caminho);

                return(true, linhas, linhas.Count());
            } catch(Exception ex)
            {
                return (false, Array.Empty<string>(), 0);
            }
        }
    }
}