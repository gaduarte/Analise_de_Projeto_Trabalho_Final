
namespace gabriela_duarte.Models
{
    public class Cliente
    {
        public int ClienteId {get; set;}
        public string? Nome {get; set;}
        public virtual ICollection<NotaDeVenda>? NotaDeVendas {get; set;}
    }
}