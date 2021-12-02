using DefaultWebAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefaultWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration) //IConfiguration wird in der Programm.cs initiiert -> an dieser Stelle repräsentiert IConfiguration die eingelesen Appsettings.json
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; } //Unsere eingelesenen Konfiguration

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) //ServiceCollection arbeiten mit dem ServiceProvider zusammen
        {

            services.AddControllers(); // AddController -> WebAP - Controller

            services.AddScoped<ITimeService, TimeService>();


            //services.AddControllersWithViews(); // MVC 
            //services.AddRazorPages(); //Razor Pages
            //services.AddMvc();


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DefaultWebAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) //Entiwckler-Instanz
            {
                app.UseDeveloperExceptionPage(); //Direkte Fehlerausgabe mit StackTrace
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DefaultWebAPI v1"));
            }

            //Für Alle
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();


            //Request -> rufen einen Controller->GET/POST/PUT/DELETE MEthode auf
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
