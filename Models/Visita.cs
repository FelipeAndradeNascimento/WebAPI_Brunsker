using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adm_Imoveis.Models
{
    [Table("tb_Visitas")]
    public class Visita
    {
        [Key]
        [Required]
        public int IdVisitas { get; set; }
        
        [Display(Name = "Cliente")]
        public int idCliente { get; set; }

        [Display(Name = "Corretor Responsável")]
        public int idCorretor { get; set; }

        [Display(Name = "Tipo de Imovel")]
        public int idImovel { get; set; }  

        public DateOnly dtVisita { get; set; }

    }
}
