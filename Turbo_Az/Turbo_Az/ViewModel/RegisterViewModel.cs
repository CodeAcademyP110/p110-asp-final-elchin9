﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turbo_Az.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, Compare(nameof(Password)), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
