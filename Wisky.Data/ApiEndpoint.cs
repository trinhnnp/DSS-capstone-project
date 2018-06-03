using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Wisky.Data.Models.Entities;
using Wisky.Data.Models.ViewModels;

namespace Wisky.Data
{
    public static class ApiEndpoint
    {
        public static void Entry(Action<IMapperConfiguration> additionalMapperConfig, params Autofac.Module[] additionalModules)
        {
            Action<IMapperConfiguration> fullMapperConfig = q =>
            {
                ApiEndpoint.ConfigAutoMapper(q);

                if (additionalMapperConfig != null)
                {
                    additionalMapperConfig(q);
                }
            };

            SkyWeb.DatVM.Mvc.Autofac.AutofacInitializer.Initialize(
                Assembly.GetExecutingAssembly(),
                typeof(WiSkyEntities),
                new MapperConfiguration(fullMapperConfig),
                additionalModules);
        }



        private static void ConfigAutoMapper(IMapperConfiguration config)
        {
            //config.createmissingtypemaps = true;
            //config.createmap<region, regionviewmodel>();
            //config.allownulldestinationvalues = false;
        }
    }
}
