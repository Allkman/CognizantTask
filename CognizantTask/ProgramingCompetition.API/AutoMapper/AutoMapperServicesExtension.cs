using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingCompetition.API.AutoMapper
{
    public static class AutoMapperServicesExtension
    {
        public static IServiceCollection ConfigureAutomapper(this IServiceCollection services)
        {
            services.AddAutoMapper(
                typeof(ChallengeProfile), 
                typeof(RootObjectProfile)
                );
            return services;
        }
    }
}
