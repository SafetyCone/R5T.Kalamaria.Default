using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Kalamaria.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OrganizationsDirectoryNameConvention"/> implmentation of <see cref="IOrganizationsDirectoryNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultOrganizationsDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddSingleton<IOrganizationsDirectoryNameConvention, OrganizationsDirectoryNameConvention>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationsDirectoryNameConvention"/> implmentation of <see cref="IOrganizationsDirectoryNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IOrganizationsDirectoryNameConvention> AddDefaultOrganizationsDirectoryNameConventionAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IOrganizationsDirectoryNameConvention>(() => services.AddDefaultOrganizationsDirectoryNameConvention());
            return serviceAction;
        }
    }
}
