using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaServicios.Model
{
    [Table("Servicios")]
    public class Servicios
    {
        [Key]
        public int ID_Servicio { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "El campo Descripción es requerido.")]
        public string Descripcion { get; set; }

        [Display(Name = "Monto")]
        [Required(ErrorMessage = "El campo Monto  es requerido.")]
        public int Monto { get; set; }

        
    }
}
