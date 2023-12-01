
namespace gabriela_duarte.Models
{
    public class Transportadora
    {
        public int TransportadoraId {get; set;}
        public string? Nome {get; set;}
        public virtual ICollection<NotaDeVenda>? NotaDeVendas {get; set;}
    }
}