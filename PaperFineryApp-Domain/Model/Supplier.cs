﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperFineryApp_Domain.Model
{
    public class Supplier:BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Profileimage { get; set; }
        public string? BusinessName { get; set; }
        //For every supply Order with Totalweight >= 5kg award 2 points, if Totalweight>=10, award 5points
        public string? ReferralPoints { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountName { get; set; }
        public string? BankName { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Reviews { get; set; }    
        //User id is a primary key here, not a foreign key
        [Key]
        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}