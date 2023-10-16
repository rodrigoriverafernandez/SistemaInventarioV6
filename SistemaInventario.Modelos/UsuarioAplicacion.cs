using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class UsuarioAplicacion : IdentityUser
    {
        [Required(ErrorMessage ="Nombre es Requerido")]
        [MaxLength(80)]

        public string Nombres { get; set; }

        [Required(ErrorMessage = "Apellidos es Requerido")]
        [MaxLength(80)]

        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Direccion es Requerido")]
        [MaxLength(200)]

        public string Direccion {  get; set; }

        [Required(ErrorMessage = "Ciudad es Requerido")]
        [MaxLength(200)]
        public string   Ciudad {  get; set; }

        [Required(ErrorMessage = "Ciudad es Requerido")]
        [MaxLength(60)]
        public string Pais { get; set; }
        [Required(ErrorMessage = "Pais es Requerido")]
        [MaxLength(60)]

        [NotMapped] // Este Campo existe pero no se agrega a la Base de Datos
        public string Role { get; set; }







    }
}
