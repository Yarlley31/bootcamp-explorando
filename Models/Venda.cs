using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace bootcamp_explorando.Models
{
    public class Venda
    {
        public int Id { get; set; }

        // atributo
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }

        public decimal Preco { get; set; }
        public DateTime DataDeVenda { get; set; }
    }
}