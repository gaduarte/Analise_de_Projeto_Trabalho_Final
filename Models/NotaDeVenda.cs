using System.ComponentModel.DataAnnotations;

namespace gabriela_duarte.Models
{
    public class NotaDeVenda
    {
        public int NotaDeVendaId {get; set;}

        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data {get; set;}

        public Boolean Tipo {get; set;}
        public virtual ICollection<Pagamento>? Pagamentos {get; set;}

        [Display(Name = "Cliente")]
        public int? ClienteId {get; set;}
        public virtual Cliente? Cliente {get; set;}

        [Display(Name = "Vendedor")]
        public int? VendedorId {get; set;}
        public virtual Vendedor? Vendedor {get; set;}

        [Display(Name = "Tipo de Pagamento")]
        public int? TipoDePagamentoId {get; set;}
         [Display(Name = "Nome do Cobrado")]
        public virtual TipoDePagamento? TipoDePagamento {get; set;}

        public Transportadora? Transportadora {get; set;}
        public virtual ICollection<Item>? Itens {get; set;}

       private bool CancelarNotas(){
        return true;
       }

       public bool Cancelar(){
        return this.CancelarNotas();
       }

       private bool DevolverNotas(){
        return true;
       }

       public bool Devolver(){
        return this.DevolverNotas();
       }
    }
}