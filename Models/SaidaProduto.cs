using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LoginProjeto.Models
{
    [Table("SaidaProduto")]
    public class SaidaProduto
    {
        [Column("Id")]
        [Display(Name = "Código da saida do produto")]
        public int Id { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Column("SaidaProdutoData")]
        [Display(Name = "Data da saida do produto")]
        public DateTime SaidaProdutoData { get; set; }

        [Column("SaidaProdutoQuantidade")]
        [Display(Name = "Quantidade de produtos que saiu")]
        public int SaidaProdutoQuantidade { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuário")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        [ForeignKey("ClienteId")]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("TipoSaidaId")]
        [Display(Name = "Tipo de saida do produto")]
        public int TipoSaidaId { get; set; }
        public TipoSaida? TipoSaida { get; set; }

    }
}
