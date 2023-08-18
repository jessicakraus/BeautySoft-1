using System.ComponentModel.DataAnnotations;
using WebApp.BeautySoft.Enums;

namespace WebApp.BeautySoft.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome de usuário")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Digite o email de usuário")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o login de usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o senha de usuário")]
        public string Password { get; set; }
        public DateTime DateRegistration { get; set; }
        public DateTime? DateUpdate { get; set; }
        public PerfilEnum Perfil { get; set; }
    }
}
