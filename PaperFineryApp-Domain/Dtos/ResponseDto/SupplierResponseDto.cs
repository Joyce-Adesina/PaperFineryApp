using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperFineryApp_Domain.Dtos.ResponseDto
{
    public class SupplierResponseDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Profileimage { get; set; }
        public string? BussinessName { get; set; }
        [Column(TypeName = "Money")]
        public decimal? PricePerKg { get; set; }
        public double? MinKilogramAccepted { get; set; }
    }
}