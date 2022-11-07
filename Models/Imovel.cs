using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adm_Imoveis.Models
{
    [Table("tb_Imovel")]
    public class Imovel
    {
        [Key]
        [Required]
        public int IdImovel { get; set; }
        
        [Required]
        [Display( Name = "Tipo de Imovel")]
        public string? Tipo { get; set; }

        [Display(Name = "Endereço:")]
        public string Endereco { get; set; }
    }
}
