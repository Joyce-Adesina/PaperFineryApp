using AutoMapper;
using Azure;
using Microsoft.Extensions.Logging;
using PaperFineryApp_Application.Services.Interfaces;
using PaperFineryApp_Domain.Dtos.RequestDto;
using PaperFineryApp_Domain.Dtos.ResponseDto;
using PaperFineryApp_Domain.Model;
using PaperFineryApp_Infrastructure.Persistence;
using PaperFineryApp_Infrastructure.Repository.Implementation;
using PaperFineryApp_Infrastructure.UnitOfWork.Abstraction;
using PaperFineryApp_Infrastructure.UnitOfWork.Implementation;
using PaperFineryApp_Shared;
using PaperFineryApp_Shared.RequestParameter.Common;
using PaperFineryApp_Shared.RequestParameter.ModelParameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperFineryApp_Application.Services.Implementations
{
    public class ManufacturerService :  IManufacturerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<ManufacturerService> _logger;
        public ManufacturerService(AppDbContext appDbContext,  IUnitOfWork unitOfWork, IMapper mapper, ILogger<ManufacturerService> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<StandardResponse<ManufacturerResponseDto>> CreateManufacturer(ManufacturerRequestDto requestDto)
        {
            var manufacturer = _mapper.Map<Manufacturer>(requestDto);
            await _unitOfWork.ManufacturerRepository.CreateAsync(manufacturer);
            await _unitOfWork.SaveChangesAsync();
            var manufacturerDto = _mapper.Map<ManufacturerResponseDto>(manufacturer);
            return StandardResponse<ManufacturerResponseDto>.Success("Successfully created new contact", manufacturerDto, 201);
        }

        public Task<StandardResponse<string>> DeleteManufacturer(string id) 
        {
            throw new NotImplementedException();
        }

        public async Task<StandardResponse<IEnumerable<ManufacturerResponseDto>>> GetAllManufacturers()
        {
            var result = await _unitOfWork.ManufacturerRepository.GetAllManufacturersAsync();
            var manufacturerDtos = _mapper.Map<IEnumerable<ManufacturerResponseDto>>(result);
            return StandardResponse<IEnumerable<ManufacturerResponseDto>>.Success("Successfully retrieved all manufacturers", manufacturerDtos, 200);
        }

        public Task<StandardResponse<ManufacturerResponseDto>> GetManufacturerById(string id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<StandardResponse<int>> UpdateManufacturer(string id, ManufacturerRequestDto requestDto)
        {
            throw new NotImplementedException();
        }
    }
}
