using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LoginProjeto.Models
{
    [Table("TipoProduto")]
    public class TipoProduto
    {
        [Column("Id")]
        [Display(Name = "Tipo do tipo de produto")]
        public int Id { get; set; }

        [Column("TipoProdutoDescricao")]
        [Display(Name = "Descrição do Tipo de Produto")]
        public string TipoProdutoDescricao { get; set; } = string.Empty;
    }
}
