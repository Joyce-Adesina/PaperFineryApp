﻿namespace PaperFineryApp_Domain.Model
{
    public class BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime ModifiedAt { get; set; } 
    }
}