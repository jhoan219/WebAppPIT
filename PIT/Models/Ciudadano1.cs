using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PIT.Models
{
    public class Ciudadano1
    {

        [Key, Required(ErrorMessage = "Campo Requerido"), Display(Name = "Codigo de ciudadano")]
        public string id_ciudadano { get; set; }

        [Display(Name = "Nombre de ciudadano")]
        public string nombre { get; set; }
        [Display(Name = "Campo Nacionalidad")]
        public string nacionalidad { get; set; }

        [Display(Name = "numero de documento")]
        public string numdocumento { get; set; } 

        [Display(Name = "tipo documento")]
        public string tipodocumento { get; set; }
        [Display(Name = "iddepartamento")]
        public string iddepartamento { get; set; }

        [Display(Name = "idprovincia")]
        public string idprovincia { get; set; }

        [Display(Name = "iddistrito")]
        public string iddistrito { get; set; }

        [Display(Name = "idestado")]
        public string idestado { get; set; }




    }
}