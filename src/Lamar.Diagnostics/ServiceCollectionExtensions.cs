using Microsoft.Extensions.DependencyInjection;
using Oakton.AspNetCore.Environment;

namespace Lamar.Diagnostics
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds an environment check to validate all the Lamar IoC configuration, including Lamar's own
        /// environment checks
        /// </summary>
        public static void CheckLamarConfiguration(this IServiceCollection services)
        {
            services.CheckEnvironment("Lamar IoC Service Registrations",s => ((IContainer)s).AssertConfigurationIsValid(AssertMode.Full));
        }
    }
}