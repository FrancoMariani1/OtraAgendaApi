using OtraAgendaApi.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace OtraAgendaApi.Dto
{
    public class CreateAndUpdateUserDTO
    {
        [Required]
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }

        public Rol Rol { get; set; } = Rol.User;
    }
}
