using System;
//using FormClearance.Areas.Identity.Data;
using FormClearance.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(FormClearance.Areas.Identity.IdentityHostingStartup))]
namespace FormClearance.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<FormClearanceContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DefaultConnection")));

                //services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<FormClearanceContext>();//.AddDefaultTokenProviders();
                services.AddIdentity<IdentityUser, IdentityRole>()
               .AddDefaultTokenProviders()
               .AddDefaultUI()
               .AddEntityFrameworkStores<FormClearanceContext>();
                //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddRoles<IdentityRole>()
                //    .AddEntityFrameworkStores<FormClearanceContext>();
            });
        }
    }
}