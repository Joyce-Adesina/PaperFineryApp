using PaperFineryApp_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperFineryApp_Infrastructure.Repository.Abstraction
{
    public interface IOrderRepository : ICommandIRepository<Order>
    {
        Task<Order> GetOrderByIdAsync(string id);
        Task<IEnumerable<Order>> GetAllOrdersAsync();
    }
}
