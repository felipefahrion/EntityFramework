using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExercicioEFCoreCodeFirst.PL
{
    public class Movie
    {
        [Required(ErrorMessage = "Informe titulo")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Informe diretor")]
        public string Director { get; set; }
        [Required]
        [Display(Name = "Data do pedido")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime ReleaseDate { get; set; }
        public decimal Gross { get; set; }
        public double Rating { get; set; }
        [Required]
        public int MovieID { get; set; }
        [Required]
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
        public virtual ICollection<ActorMovie> Characters { get; set; }
    }
}
