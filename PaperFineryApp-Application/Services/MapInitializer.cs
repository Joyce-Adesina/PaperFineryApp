using AutoMapper;
using PaperFineryApp_Domain.Dtos.RequestDto;
using PaperFineryApp_Domain.Dtos.ResponseDto;
using PaperFineryApp_Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperFineryApp_Application.Services
{
    public class MapInitializer : Profile
    {
        public MapInitializer()
        {
            CreateMap<Manufacturer, ManufacturerResponseDto>();
            CreateMap<ManufacturerRequestDto, Manufacturer>();
            CreateMap<Supplier, SupplierResponseDto>();
            CreateMap<SupplierRequestDto, Supplier>();
            CreateMap<Order, OrderResponseDto>();
            CreateMap<OrderRequestDto, Order>();
            CreateMap<User, UserResponseDto>();
            CreateMap<UserRequestDto, User>();
            CreateMap<string, Review>();
            ///<Summary>
            ///<param name="u">Represents ReviewResponseDto </param>
            ///<param name="opt">MemberConfigurationExpression for relating Review, ReviewResponseDto and UserRespponseDto</param>
            ///<param name="src"> Represents Review </param>
            ///</Summary>
            CreateMap<Review, ReviewResponseDto>().ForMember(u=>u.UserReviewer, opt => opt.MapFrom(src => src.UserReviewer));
        }
    }
}

