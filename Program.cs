using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NEW__Razor_Upravljalec_nalog.Data;
using Microsoft.AspNetCore.Identity;
namespace NEW__Razor_Upravljalec_nalog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<NEW__Razor_Upravljalec_nalogContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("NEW__Razor_Upravljalec_nalogContext") ?? throw new InvalidOperationException("Connection string 'NEW__Razor_Upravljalec_nalogContext' not found.")));

                        builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<NEW__Razor_Upravljalec_nalogContext>();
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();
            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            else
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var context = services.GetRequiredService<NEW__Razor_Upravljalec_nalogContext>();
                context.Database.EnsureCreated();
                Seed.Initialize(context);
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();;

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}