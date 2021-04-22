using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaServicios.Model
{
    [Table("Vehiculo")]
    public class Vehiculo
    {
        [Key]
        public int ID_Vehiculo { get; set; }

        [Display(Name = "Placa del vehículo")]
        [Required(ErrorMessage = "El campo Placa del vehículo es requerido.")]
        public string Placa { get; set; }

        [Display(Name = "Nombre del dueño")]
        [Required(ErrorMessage = "El campo Nombre del dueño  es requerido.")]
        public string Dueno { get; set; }

        [Display(Name = "Marca Del vehículo")]
        [Required(ErrorMessage = "El campo vehículo  es requerido.")]
        public string Marca { get; set; }
    }
}
