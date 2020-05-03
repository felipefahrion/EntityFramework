using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExercicioEFCoreCodeFirst.PL
{
    public class Movie
    {
        [Required(ErrorMessage = "Informe um titulo para o filme")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Informe um diretor para o filme")]
        public string Director { get; set; }
        [Required]
        [Display(Name = "Informe a data de realização do filme")]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime ReleaseDate { get; set; }
        public decimal Gross { get; set; }
        public double Rating { get; set; }
        [Required]
        public int MovieID { get; set; }
        [Required]
        public int GenreID { get; set; }
        [Required(ErrorMessage = "Informe um gênero para o filme")]
        public Genre Genre { get; set; }
        public virtual ICollection<ActorMovie> Characters { get; set; }
    }
}
