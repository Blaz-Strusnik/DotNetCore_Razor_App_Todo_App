using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Upravljalec_Nalog.Areas.Identity.Data;
using Upravljalec_Nalog.Data;

[assembly: HostingStartup(typeof(Upravljalec_Nalog.Areas.Identity.IdentityHostingStartup))]
namespace Upravljalec_Nalog.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Upravljalec_NalogContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Upravljalec_NalogContextConnection")));

                services.AddDefaultIdentity<Upravljalec_NalogUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Upravljalec_NalogContext>();
            });
        }
    }
}