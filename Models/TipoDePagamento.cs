using System.ComponentModel.DataAnnotations;

namespace gabriela_duarte.Models
{
    public class TipoDePagamento
    {
       public int TipoDePagamentoId {get; set;}

       [Display(Name = "Nome do Cobrado")]
       public string? NomeDoCobrado {get; set;}

       [Display(Name = "Informações Adicionais")]
       public string? InformacoesAdicionais {get; set;}
       public virtual ICollection<NotaDeVenda>? NotaDeVendas {get; set;}
    }
}