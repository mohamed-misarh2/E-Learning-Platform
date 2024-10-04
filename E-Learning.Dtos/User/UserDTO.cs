﻿using System.ComponentModel.DataAnnotations.Schema;

namespace E_Learning.Dtos.User
{
    [NotMapped]
    public class UserDTO
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsBlocked { get; set; }
        public string Role { get; set; }

    }
}
