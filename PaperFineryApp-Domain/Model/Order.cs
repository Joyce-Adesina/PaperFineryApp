using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperFineryApp_Domain.Model
{
    public class Order:BaseEntity
    {
        public string? Id { get; set; } = Guid.NewGuid().ToString();
        public string? OrderReference { get; set; }
        public double? TotalWeightInKg { get; set; }
        public string? PaperTypeAndKg { get; set; }
        public DateTime OrderInitializationTime { get; set; } 
        //public DeliveryMode DeliveyrMode { get; set; }
        //public OrderStatus OrderStatus { get; set; }
        public string? Location { get; set; }
        public string? ImageUrl { get; set; }
        [ForeignKey(nameof(Supplier))]
        public string SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
