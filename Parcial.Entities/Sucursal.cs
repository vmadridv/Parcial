using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entities
{
    public class Sucursal
    {
        [Key]//Para que sea key si se quiere Code
        public int IdSucursal { get; set; }
        [MaxLength(30)]
        [Required]
        public string Nombre { get; set; }
        [MaxLength(50)]
        [Required]

        public string Departamento { get; set; }
        [Required]

        public string Telefono { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
    
}
