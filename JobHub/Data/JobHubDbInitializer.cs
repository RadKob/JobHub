using JobHub.Models;
using System.Data;

namespace JobHub.Data
{
    public class JobHubDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<JobHubDbContext>();
                context.Database.EnsureCreated();
                if(!context.Users.Any())
                {
                    context.Users.Add(new User()
                    {
                        name = "Administrator",
                        surname = "Systemu",
                        role = "ADMIN",
                        email = "admin@poczta.pl",
                        password = "zaq1@WSX",
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now,
                        is_del = false,
                        deleted_at = null
                    });
                }
                context.SaveChanges();
            }
        }
    }
}
