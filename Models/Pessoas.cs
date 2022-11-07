using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adm_Imoveis.Models
{
    [Table("tb_Pessoas")]
    public class Pessoas
    {
        /// <summary>
        /// Identificação única do registro
        /// </summary>
        [Key]
        [Required]
        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "Favor informar o Nome da Usuário")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe o email para contato")]
        public string? Email { get; set; }

        [StringLength(11, ErrorMessage = "Informe o telefone no seguinte formato: 31999999999")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "Favor informar o Tipo de Usuário")]
        public int IdTipo { get; set; }
    }
}
