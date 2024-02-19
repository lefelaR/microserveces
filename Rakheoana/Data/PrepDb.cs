using Rakheoana.Models;

namespace Rakheoana.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }
        private static void SeedData(AppDbContext context)
        {

            if (!context.Platforms.Any())
            {
                Console.WriteLine("--> Seeding Data");
                context.Platforms.AddRange(
                    new Platform() {Name="DotNet" , Publisher="Microsoft", Cost="Free" },
                    new Platform() { Name="SQl server Express", Publisher="Microsoft" , Cost="ree"},
                    new Platform() { Name ="Kubenetese", Publisher="Microsoft",  Cost="Free"}
                    );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("-->we already have data");
            }


        }
    }
}