using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaperFineryApp_Application.Services.Interfaces;

namespace PaperFineryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpGet]
        public  async Task<IActionResult> GetAllSuppliers()
        {
            var result = await _supplierService.GetAllSuppliersAsync();
            return Ok(result);
        }
    }
}
