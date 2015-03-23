﻿using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    /// <summary>
    /// Entity, that represents user of a system
    /// </summary>
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string ExternalAccountName { get; set; }

        [Required]
        public string Email { get; set; }

        public UserRole Role { get; set; }
    }
}