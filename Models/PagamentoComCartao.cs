using System.ComponentModel.DataAnnotations;

namespace gabriela_duarte.Models
{
    public class PagamentoComCartao: TipoDePagamento
    {
        [Display(Name = "Número do Cartão")]
        public string? NumeroDoCartao {get; set;}
        public string? Bandeira {get; set;}
    }
}