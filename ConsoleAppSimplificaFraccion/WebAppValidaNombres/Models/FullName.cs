using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAppValidaNombres.Models
{
    public class FullName
    {
        //"^(?=.{2,40}$)([A-ZÀ-ÿ][a-z.])+$"
        
        [RegularExpression(@"^[A-ZÀ-ÿ]{1}[a-z.]+$", ErrorMessage = @"a) Tanto las iniciales como las palabras completas deben estar capitalizadas (la primera letra en mayúsculas)\nb) Las iniciales deben terminar en punto(.)")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Remark must have min length of 2 and max Length of 40")]
        [Required]
        [DisplayName("Primer Nombre")]
        public string priNombre { get; set; }

        [DisplayName("Segundo Nombre")]
        public string segNombre { get; set; }

        [RegularExpression(@"^(?=.{1,40}$)[A-Z][a-z]*")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Remark must have min length of 10 and max Length of 40")]
        [Required]
        [DisplayName("Apellido")]
        public string apellido { get; set; }
    }
}