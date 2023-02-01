using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebEmpleado.Validations
{
    public class CheckFechaNacimientoAttribute: ValidationAttribute
    {
        public CheckFechaNacimientoAttribute()
        {
            ErrorMessage = "La fecha de nacimiento debe ser mayor al año 2000";
        }
        public override bool IsValid(object value)
        {
            if(value != null)
            {
                DateTime fecha = Convert.ToDateTime(value);
                if (fecha.Year < 2000)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
    }
}
