using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using zad3FizzBuzzWebApp.Data;

[assembly: HostingStartup(typeof(zad3FizzBuzzWebApp.Areas.Identity.IdentityHostingStartup))]
namespace zad3FizzBuzzWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<zad3FizzBuzzWebAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("zad3FizzBuzzWebAppContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<zad3FizzBuzzWebAppContext>();
            });
        }
    }
}