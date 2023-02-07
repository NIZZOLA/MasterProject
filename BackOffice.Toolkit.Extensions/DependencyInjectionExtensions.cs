﻿using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace BackOffice.Toolkit.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void ScanDependencyInjection(this IServiceCollection services, Assembly projectAssembly,
            string classesEndWith)
        {
            var types = projectAssembly.GetTypes().Where(x => x.GetInterfaces().Any(i => i.Name.EndsWith(classesEndWith)));

            foreach (var type in types)
            {
                var interfaces = type.GetInterfaces();
                foreach (var inter in interfaces)
                    services.AddScoped(inter, type);
            }
        }
    }
}