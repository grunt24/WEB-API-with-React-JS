﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASSISTmentsBackend.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [NotMapped]
        public IList<string> Roles { get; set; }

    }
}
