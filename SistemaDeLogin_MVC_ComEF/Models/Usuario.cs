using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace SistemaDeLogin_MVC_ComEF.Models
{
    [Index(nameof(Nome_Usuario), nameof(CPF), nameof(Email), IsUnique = true)]

    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome_Usuario { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string CPF{ get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataDeNascimento { get; set;}

    }
}
