using System;
using System.ComponentModel.DataAnnotations;

namespace gabriela_duarte.Models
{
    public class Pagamento
    {
        public int PagamentoId {get; set;}

        [Display (Name = "Data Limite")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataLimite {get; set;}
        public double? Valor {get; set;}
        public Boolean? Pago {get; set;}
        public int NotaDeVendaId {get; set;}

        public virtual NotaDeVenda? NotaDeVenda {get; set;}
    }
}