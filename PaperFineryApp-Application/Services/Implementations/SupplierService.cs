using AutoMapper;
using Microsoft.Extensions.Logging;
using PaperFineryApp_Application.Services.Interfaces;
using PaperFineryApp_Domain.Dtos.RequestDto;
using PaperFineryApp_Domain.Dtos.ResponseDto;
using PaperFineryApp_Domain.Model;
using PaperFineryApp_Infrastructure.UnitOfWork.Abstraction;
using PaperFineryApp_Shared;
using PaperFineryApp_Shared.RequestParameter.Common;
using PaperFineryApp_Shared.RequestParameter.ModelParameter;

namespace PaperFineryApp_Application.Services.Implementations
{
    public class SupplierService : ISupplierService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<SupplierService> _logger;
        public SupplierService(IUnitOfWork unitOfWork, IMapper mapper, ILogger<SupplierService> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<StandardResponse<SupplierResponseDto>> CreateSupplier(SupplierRequestDto requestDto)
        {
            var supplier = _mapper.Map<Supplier>(requestDto);
            await _unitOfWork.SupplierRepository.CreateAsync(supplier);
            await _unitOfWork.SaveChangesAsync();
            var supplierDto = _mapper.Map<SupplierResponseDto>(supplier);
            return StandardResponse<SupplierResponseDto>.Success("Successfully created new contact", supplierDto, 201);
        }

        public async Task<StandardResponse<IEnumerable<SupplierResponseDto>>> GetAllSuppliersAsync()
        {
            var result = await _unitOfWork.SupplierRepository.GetAllSuppliersAsync();
            var supplierDtos = _mapper.Map<IEnumerable<SupplierResponseDto>>(result);
            return StandardResponse<IEnumerable<SupplierResponseDto>>.Success("Successfully retrieved all manufacturers", supplierDtos, 200);
        }
    }
}
