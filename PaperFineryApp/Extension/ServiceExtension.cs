using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using PaperFineryApp_Application.Services.Implementations;
using PaperFineryApp_Application.Services.Interfaces;
using PaperFineryApp_Domain.Model;
using PaperFineryApp_Infrastructure.Persistence;
using PaperFineryApp_Infrastructure.UnitOfWork.Abstraction;
using PaperFineryApp_Infrastructure.UnitOfWork.Implementation;

namespace PaperFineryApp.Extension
{
    public static class ServiceExtension
    {
        public static void ResolveDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IManufacturerService, ManufacturerService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
/*            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPhotoService, PhotoService>();*/
        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentity<User, IdentityRole>(o =>
            {
                o.Password.RequireDigit = false;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = true;
                o.Password.RequiredLength = 10;
                o.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();
        }
    }
}
