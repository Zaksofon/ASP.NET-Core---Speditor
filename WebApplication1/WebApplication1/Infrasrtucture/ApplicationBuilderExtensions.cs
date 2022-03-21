using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Speditor.Data;
using Speditor.Data.Models;

namespace Speditor.Infrasrtucture
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<SpeditorDbContext>();

            data.Database.Migrate();

            SeedCargoSpaceDimensions(data);

            SeedCargoSpaceType(data);

            return app;
        }

        private static void SeedCargoSpaceType(SpeditorDbContext data)
        {
            if (data.CargoSpaceTypes.Any())
            {
                return;
            }
            data.CargoSpaceTypes.AddRange(new []
            {
                new CargoSpaceType{Name = "OnBoard"},
                new CargoSpaceType{Name = "Vans"},
                new CargoSpaceType{Name = "Platforms"},
                new CargoSpaceType{Name = "Gondolas"},
                new CargoSpaceType{Name = "Tanks"},
                new CargoSpaceType{Name = "ContainerVessels"}
            });

            data.SaveChanges();
        }

        private static void SeedCargoSpaceDimensions(SpeditorDbContext data)
        {
            if (data.CargoSpaceDimensions.Any())
            {
                return;
            }
            data.CargoSpaceDimensions.AddRange(new []
            {
                new CargoSpaceDimension{Name = "Trailer"},
                new CargoSpaceDimension{Name = "Hanger"},
                new CargoSpaceDimension{Name = "MegaTrailer"},
                new CargoSpaceDimension{Name = "Jumbo"}
            });

            data.SaveChanges();
        }
    }
}
