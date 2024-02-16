using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Service.Services.Abstractions;
using Service.Services.Concretes;
using System.Globalization;
using System.Reflection;
using Service.Validations;
using Service.Helpers;


namespace Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();


            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IImageHelper, ImageHelper>();
            services.AddScoped<IDashbordService, DashboardService>();
            services.AddScoped<IAuthService, AuthService>();


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddAutoMapper(assembly);


            services.AddControllersWithViews()
                .AddFluentValidation(opt =>
                {
                    opt.RegisterValidatorsFromAssemblyContaining<ArticleValidator>();
                    _ = opt.DisableDataAnnotationsValidation;
                    opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");    
                    
                });


            return services;


        }
    }
}
