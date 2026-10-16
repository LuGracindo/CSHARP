using BookStoreManager.Application.AutoMapper;
using BookStoreManager.Application.UseCases.Books.Register;
using Microsoft.Extensions.DependencyInjection;

namespace BookStoreManager.Application
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            AddAutoMapper(services);
            AddUseCases(services);
        }

        private static void AddAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(cfg => { }, typeof(AutoMapping));
        }

        private static void AddUseCases(IServiceCollection services)
        {
            services.AddScoped<IRegisterBookUseCase, RegisterBookUseCase>();
        }
    }
}
