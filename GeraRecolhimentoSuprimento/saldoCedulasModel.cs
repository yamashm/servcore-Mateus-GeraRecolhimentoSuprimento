using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeraRecolhimentoSuprimento
{
    public class ModeloSaidaSaldoCedulas
    {
        public int nrRetorno { get; set; }
        public string txRetorno { get; set; }
        public int qtd_cedulas_cassete_A { get; set; }
        public decimal valor_cedulas_cassete_A { get; set; }
        public int qtd_cedulas_rejeitadas_A { get; set; }
        public int qtd_cedulas_cassete_B { get; set; }
        public decimal valor_cedulas_cassete_B { get; set; }
        public int qtd_cedulas_rejeitadas_B { get; set; }
        public int qtd_cedulas_cassete_C { get; set; }
        public decimal valor_cedulas_cassete_C { get; set; }
        public int qtd_cedulas_rejeitadas_C { get; set; }
        public int qtd_cedulas_cassete_D { get; set; }
        public decimal valor_cedulas_cassete_D { get; set; }
        public int qtd_cedulas_rejeitadas_D { get; set; }
    }
}
