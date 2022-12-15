using OtraAgendaApi.Entities;
using System.ComponentModel.DataAnnotations;

namespace OtraAgendaApi.Dto
{
    public class CreateAndUpdateContactDTO
    {
        [Required]
        public string Name { get; set; }
        public string LastName { get; set; }
        public int CelularNumber { get; set; }
        public int TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string Description = String.Empty;
        public User? User;

    }
}