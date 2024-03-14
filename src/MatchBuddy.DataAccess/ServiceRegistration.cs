using DataAccess.Concrete.EntityFramework;
using MatchBuddy.DataAccess.Abstract;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class ServiceRegistration
    {
        public static void AddDataAccessRegistration(this IServiceCollection services)
        {
            services.AddScoped<IPlayerDal, EFPlayerDal>();
            //services.AddScoped<ICustomerDal, Ef>();
            //services.AddScoped<IOrderDal, EFOrderDal>();
            //services.AddScoped<IProductDal, EFProductDal>();
        }
    }
}
