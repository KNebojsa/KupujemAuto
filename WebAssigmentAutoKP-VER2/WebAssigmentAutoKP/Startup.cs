using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using WebAssigmentAutoKP.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebAssigmentAutoKP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

namespace WebAssigmentAutoKP
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddDbContext<AutomobilContext>(opcije =>
           opcije.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.AddLocalization();
            services.AddMvc().AddDataAnnotationsLocalization(opts => {
                opts.DataAnnotationLocalizerProvider = (type, factory) => factory.Create(typeof(Resource));
            }).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.Configure<RequestLocalizationOptions>(
                  opts =>
                  {
                      var supported = new[] {
                        new CultureInfo("sr"),
                         new CultureInfo("en"),
                          new CultureInfo("it-IT")

                      };
                      opts.DefaultRequestCulture = new RequestCulture(culture: "sr", uiCulture: "sr-Latn-RS");
                      opts.SupportedCultures = supported;
                      opts.SupportedUICultures = supported;
                  });

            services.Configure<IdentityOptions>(opcije =>
            {
                opcije.Password.RequireDigit = false;
                opcije.Password.RequiredLength = 3;
                opcije.Password.RequiredUniqueChars = 1;
                opcije.Password.RequireLowercase = false;
                opcije.Password.RequireNonAlphanumeric = false;
                opcije.Password.RequireUppercase = false;

                opcije.User.RequireUniqueEmail = false;
            });


            services.AddControllersWithViews();
            services.AddRazorPages();
          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseRequestLocalization();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Automobil}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
