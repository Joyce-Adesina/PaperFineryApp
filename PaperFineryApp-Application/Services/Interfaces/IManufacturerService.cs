using PaperFineryApp_Domain.Dtos.RequestDto;
using PaperFineryApp_Domain.Dtos.ResponseDto;
using PaperFineryApp_Domain.Model;
using PaperFineryApp_Infrastructure.Repository.Abstraction;
using PaperFineryApp_Shared;
using PaperFineryApp_Shared.RequestParameter.Common;
using PaperFineryApp_Shared.RequestParameter.ModelParameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperFineryApp_Application.Services.Interfaces
{
    public interface IManufacturerService
    {
        Task<StandardResponse<ManufacturerResponseDto>> CreateManufacturer(ManufacturerRequestDto requestDto);
        Task<StandardResponse<IEnumerable<ManufacturerResponseDto>>> GetAllManufacturers();
/*        Task<StandardResponse<ManufacturerResponseDto>> GetManufacturerById(string id, bool trackChanges);
        Task<StandardResponse<int>> UpdateManufacturer(string id, ManufacturerRequestDto requestDto);
        Task<StandardResponse<string>> DeleteManufacturer(string id);*/
    }
}
