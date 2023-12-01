using System.ComponentModel.DataAnnotations;

namespace gabriela_duarte.Models
{
    public class Marca
    {
        public int MarcaId {get; set;}
        public string? Nome {get; set;}

        [Display(Name = "Descrição")]
        public string? Descricao {get; set;}

        public virtual ICollection<Produto>? Produtos {get; set;}
    }
}