using System;
using EcommerceWebAula.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EcommerceWebAula.Areas.Identity.IdentityHostingStartup))]
namespace EcommerceWebAula.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EcommerceWebAulaContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("EcommerceWebAulaContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<EcommerceWebAulaContext>();
            });
        }
    }
}