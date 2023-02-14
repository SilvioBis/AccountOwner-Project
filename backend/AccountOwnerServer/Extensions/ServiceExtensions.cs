
namespace AccountOwnerServer.Extensions;

    public static class ServiceExtensions
    {
       public static void ConfigureCors(this IServiceCollection services)
       {
           services.AddCors(options =>
           {
            options.AddPolicy("CorsPolicy",
                    builder => builder
                    .AllowAnyOrigin() //WithOrigins("Dominio") como definir um dominio especifico
                    .AllowAnyMethod() // WithMethods("GET","POST") Tipo de ação que a api vai realizar
                    .AllowAnyHeader() //WithHeaders("acept","cont")

                );
           });
        
        }
        public static void ConfigureIISIntegration(this IServiceCollection services)     
        {
            services.Configure<IISOptions>(options =>    {

            });
        }
    }    
