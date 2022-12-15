﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OtraAgendaApi.Entities
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public int? TelephoneNumber { get; set; }
        public int CelularNumber { get; set; }
        public string? Description { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public int UserId { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }


    }
}

