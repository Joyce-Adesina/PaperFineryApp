﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperFineryApp_Domain.Dtos.ResponseDto
{
    public class UserResponseDto
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        //public MembershipType Type { get; set; }
        public string PhoneNumber { get; set; }
    }
}