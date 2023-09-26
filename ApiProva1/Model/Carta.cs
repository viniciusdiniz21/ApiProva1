using System.ComponentModel.DataAnnotations;

namespace ApiProva1.Model
{
    public class Carta
    {
        [Required(ErrorMessage = "{0} is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(255, MinimumLength = 3,
        ErrorMessage = "Last Name should be minimum 3 characters and a maximum of 255 characters")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public Endereco Endereco { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Range(0, 15, ErrorMessage = "Idade tem de ser até 15 anos")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(500, MinimumLength = 1,
        ErrorMessage = "Last Name should be minimum 1 characters and a maximum of 500 characters")]
        public string Texto { get; set; }   
    }
}
