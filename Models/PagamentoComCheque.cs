using System.ComponentModel.DataAnnotations;

namespace gabriela_duarte.Models
{
    public class PagamentoComCheque: TipoDePagamento
    {
        public int Banco {get; set;}

        [Display(Name = "Nome do Banco")]
        public string? NomeDoBanco {get; set;}
    }
}