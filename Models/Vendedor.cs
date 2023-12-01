using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gabriela_duarte.Models
{
    public class Vendedor
    {
        public int VendedorId {get; set;}
        public string? Nome {get; set;}
        public virtual ICollection<NotaDeVenda>? NotaDeVendas {get; set;}
    }
}