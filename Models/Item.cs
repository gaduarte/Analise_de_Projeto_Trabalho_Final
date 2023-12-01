using System.ComponentModel.DataAnnotations;

namespace gabriela_duarte.Models
{
    public class Item
    {
        public int ItemId {get; set;}

        [Display(Name = "Preço")]
        public double? Preco {get; set;}
        public int? Percentual {get; set;}
        public int? Quantidade {get; set;}

        [Display(Name = "Produto")]
        public int? ProdutoId {get; set;}
        public virtual Produto? Produto {get; set;}
        public virtual NotaDeVenda? NotaDeVenda {get; set;}
    }
}