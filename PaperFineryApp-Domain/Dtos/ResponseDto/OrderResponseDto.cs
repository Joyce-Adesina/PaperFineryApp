using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperFineryApp_Domain.Dtos.ResponseDto
{
    public class OrderResponseDto
    {
        public string? Id { get; set; }
        public string? OrderReference { get; set; }
        public double? TotalWeightInKg { get; set; }
        public string? PaperTypeAndKg { get; set; }
        public DateTime OrderInitializationTime { get; set; }
        //public DeliveryMode DeliveyrMode { get; set; }
        //public OrderStatus OrderStatus { get; set; }
        public string? Location { get; set; }
        public string? ImageUrl { get; set; }
    }
}
