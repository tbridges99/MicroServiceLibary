using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Voltron.Hackathon.Context;
using Voltron.Hackathon.Repositories;

namespace Voltron.Hackathon
{
    public class Startup
    {
        public Startup(IHostingEnvironment environment)
        {
            Hosting = environment;
            var builder = new ConfigurationBuilder()
                .SetBasePath(environment.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }
        private IHostingEnvironment Hosting { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(Configuration);

            services.AddMvc(options =>
            {
                options.RespectBrowserAcceptHeader = true;
                options.FormatterMappings.SetMediaTypeMappingForFormat("xml", "text/xml");
                options.FormatterMappings.SetMediaTypeMappingForFormat("json", "application/json");
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            RegisterSwagger(services);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Contact = new Contact { Email = "service@bhhc.com", Name = "Support" },
                    Title = "BHHC Service Directory API",
                    Description = "A micro-service to help locate available services",
                    Version = "v1"
                });
            });

            // Setup Autofac
            var builder = new ContainerBuilder();

            //Contexts
            services.AddDbContext<ServiceDirectoryContext>(options => options.UseSqlServer(Configuration.GetConnectionString("VoltronTest")));

            builder.RegisterType<ServiceRepository>().As<IServiceRepository>();

            builder.Populate(services);

            var container = builder.Build();
            return new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseStaticFiles();

            app.UseSwagger();

            app.UseSwaggerUI(options => {
                options.SwaggerEndpoint($"/swagger/v1/swagger.json", "BHHC Service Directory API");
            });

            app.UseMvc();
        }
        private void RegisterSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                foreach (string file in Directory.GetFiles(basePath, "*.xml"))
                {
                    options.IncludeXmlComments(Path.Combine(basePath, file));
                }
            }); 
        }
    }
}
