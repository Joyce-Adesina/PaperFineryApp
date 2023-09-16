using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperFineryApp_Domain.Model
{
    public class Review:BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public User UserReviewer { get; set; }
        public string Comment { get; set; }
    }
}