using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICourseService.Data;
using WebApiContrib.Core.Formatter.Csv;
using WebAPICourseService.Formatter;
using WebAPICourseService.Models;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc.Formatters;
using WebAPICourseService.Services;

namespace WebAPICourseService
{
    public class Startup
    {
        public Startup(IConfiguration configuration) //Wir aus unserem IOC Container geladen
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; } //repräsentiert unsere Konfigurationen (appsetting.json and mehr) 

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers( options =>
            {
                options.OutputFormatters.Insert(0, new VCardOutputFormatter());
                options.InputFormatters.Insert(0, new VCardInputFormatter());

                options.InputFormatters.Insert(1, GetJsonPatchInputFormatter());
            })
                .AddNewtonsoftJson()
                .AddXmlSerializerFormatters()
                .AddCsvSerializerFormatters();


            services.AddHttpClient<IVideoStream, VideoStream>();

            services.AddDbContext<MovieDbContext>(options => {
                options.UseInMemoryDatabase("MovieDB");
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPICourseService", Version = "v1" });
            });

            services.AddTransient<IFileService, FileService>();


            services.Configure<SampleWebSettings>(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPICourseService v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }


        private static NewtonsoftJsonPatchInputFormatter GetJsonPatchInputFormatter()
        {
            var builder = new ServiceCollection()
                .AddLogging()
                .AddMvc()
                .AddNewtonsoftJson()
                .Services.BuildServiceProvider();

            return builder.GetRequiredService<IOptions<MvcOptions>>()
                .Value
                .InputFormatters
                .OfType<NewtonsoftJsonPatchInputFormatter>()
                .First();
        }
    }

    
}
