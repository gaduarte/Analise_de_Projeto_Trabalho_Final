using System.ComponentModel.DataAnnotations;

namespace gabriela_duarte.Models
{
    public class Produto
    {
        public int ProdutoId {get; set;}
        public string? Nome {get; set;}

        [Display (Name = "Descrição")]
        public string? Descricao {get; set;}
        public int? Quantidade {get; set;}

        [Display(Name = "Preço")]
        public double? Preco {get; set;}

        [Display(Name = "Marca")]
        public int? MarcaId {get; set;}
        public virtual Marca? Marca {get; set;}

        public virtual ICollection<Item>? Itens {get; set;}
    }
}