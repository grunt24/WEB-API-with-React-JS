﻿using System.ComponentModel.DataAnnotations;

namespace ASSISTmentsBackend.Core.DTOs.Auth
{
    public class UpdateRoleDto
    {
        [Required(ErrorMessage ="UserName is required")]
        public string UserName { get; set; }
        public RoleType NewRole { get; set; }
    }

    public enum RoleType
    {
        Admin,
        Manager,
        User
    }

}
