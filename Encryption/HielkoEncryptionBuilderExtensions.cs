using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hielko.Encryption
{
    public static class HielkoEncryptionBuilderExtensions
    {
        public static IServiceCollection AddHielkoEncryption(this IServiceCollection services, IConfiguration config)
        {
            services.AddOptions<EncryptionOptions>().Bind(config.GetSection("Hielko:Encryption"));
            services.AddSingleton<IEncryption, Encryption>();

            return services;
        }
    }
}
