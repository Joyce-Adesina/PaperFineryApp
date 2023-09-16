using PaperFineryApp_Domain.Dtos.ResponseDto;
using PaperFineryApp_Shared.RequestParameter.Common;
using PaperFineryApp_Shared.RequestParameter.ModelParameter;
using PaperFineryApp_Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaperFineryApp_Domain.Dtos.RequestDto;

namespace PaperFineryApp_Application.Services.Interfaces
{
    public interface ISupplierService
    {
        Task<StandardResponse<SupplierResponseDto>> CreateSupplier(SupplierRequestDto requestDto);
        Task<StandardResponse<IEnumerable<SupplierResponseDto>>> GetAllSuppliersAsync();
    }
}
