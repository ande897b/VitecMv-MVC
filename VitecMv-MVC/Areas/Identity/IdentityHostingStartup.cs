using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VitecMv_MVC.Models;

[assembly: HostingStartup(typeof(VitecMv_MVC.Areas.Identity.IdentityHostingStartup))]
namespace VitecMv_MVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<VitecMv_MVCUserContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("VitecMv_MVCUserContextConnection")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<VitecMv_MVCUserContext>();
            });
        }
    }
}