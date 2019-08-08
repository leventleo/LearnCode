using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnCode.Bussiness.Concreats;
using LearnCode.Bussiness.Interfaces;
using LearnCode.Entities;
using LLearnCode.Bussiness.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace LearnCode.WepApi
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


            services.AddDbContext<LessonDbContext>(ServiceLifetime.Transient);

            services.AddScoped<ILesson, LessonDal>();
            services.AddScoped<IContent, ContentDal>();
            services.AddScoped<ISubject, SubjectDal>();
            services.AddScoped<IViewLevel, ViewLevelDal>();
            services.AddScoped<ISourceFile, SourceFileDal>();
            services.AddScoped<ICommandIndex, CommandIndexDal>();
            services.AddScoped<IFileStore, FileStoreDal>();
            services.AddCors();
            services.AddResponseCaching();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseResponseCaching();
            app.UseCors(config=> {

                config.AllowAnyOrigin();

            });
            app.Use(async (context, next) =>
            {
                // For GetTypedHeaders, add: using Microsoft.AspNetCore.Http;
                context.Response.GetTypedHeaders().CacheControl =
                    new Microsoft.Net.Http.Headers.CacheControlHeaderValue()
                    {
                        Public = true,
                        MaxAge = TimeSpan.FromSeconds(10)
                    };
                context.Response.Headers[Microsoft.Net.Http.Headers.HeaderNames.Vary] =
                    new string[] { "Accept-Encoding" };

                await next();
            });
            app.UseMvc();
        }
    }
}
