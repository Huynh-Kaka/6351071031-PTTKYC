using BTL_WINFORM;
using BTL_WINFORM.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_WINFORM.Models.Entities;
//using BTL_WINFORM.Views;

namespace BTL_WINFORM
{
    public static class ServiceConfigurator
    {
        // Method to configure services
        public static ServiceProvider ConfigureServices(ServiceCollection services, IConfiguration configuration)
        {

            // Register configuration so it can be injected
            services.AddSingleton<IConfiguration>(configuration);

            // Register ApplicationDbContext with the connection string from config
            services.AddDbContext<MyDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Add other services here if needed
            services.AddTransient<AdminVoucherForm>(); 
            services.AddTransient<fLogin>();
            services.AddTransient<AdminStaffForm>();
            services.AddTransient<AdminDashboardForm>();
            services.AddTransient<AdminAddAcountsForm>();
            services.AddTransient<AdminAddProductsForm>();



            // Apply pending migrations at startup
            var serviceProvider = services.BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<MyDbContext>();
                context.Database.Migrate(); // This applies pending migrations
            }
            return services.BuildServiceProvider();
        }
    }
}
