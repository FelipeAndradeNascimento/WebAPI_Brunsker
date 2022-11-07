using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Adm_Imoveis.Models
{
    [Table("tb_TipoPessoa")]
    public class TipoPessoa
    {
        [Key]
        [Required]
        public int IdTipo { get; set; }

        [Required(ErrorMessage ="Informe o tipo de usuário:(Corretor ou Cliente)")]
        [Display(Name ="Descrição")]
        public string DescricaoTipo { get; set; }
    }
}
