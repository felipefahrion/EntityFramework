using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExercicioEFCoreCodeFirst.PL
{
    public class Actor
    {
        public int ActorId { get; set; }
        [Required(ErrorMessage = "Informe nome")]
        public String Name { get; set; }
        [Required]
        [Display(Name = "informe uma data de nascimento")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime DateBirth { get; set; }
        public virtual ICollection<ActorMovie> Characters { get; set; }
    }
}
