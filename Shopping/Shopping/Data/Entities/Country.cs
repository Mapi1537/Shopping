using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        
        [Display(Name = "Pais")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} cracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int Name { get; set; }

    }
}
