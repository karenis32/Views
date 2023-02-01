using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SistemaWebEmpleado.Validations;

namespace SistemaWebEmpleado.Models
{
    
    public class Empleado
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]//view/ef
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]//view
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]//view/ef
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]//view
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]//view/ef
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]//view
        public string DNI { get; set; }

        [RegularExpression(@"^[a-zA-Z]{1}[1-9]{4}", ErrorMessage ="El legajo debe tener una letra y cuatro números")]
        public string Legajo { get; set; }

        [CheckFechaNacimientoAttribute]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]//view/ef
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]//view
        public string Titulo { get; set; }
    }
}
