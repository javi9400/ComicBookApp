using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicBook.Api.Commons;
using ComicBook.Api.Context;
using ComicBook.Api.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ComicBook.Api
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
            services.AddCors(options=>
            {
                options.AddPolicy("AllowOrigin",
            builder => builder.WithOrigins("http://localhost:3000").WithOrigins("https://localhost:3000")
            );
            }
            );
            services.AddControllers();
            services.AddScoped<IComicBookRepository, ComicBookRepository>();
            services.AddDbContext<ComicBookContext>(options =>
             options.UseNpgsql(Configuration.GetConnectionString("ComicBookDb")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();

            app.UseAuthorization();
            app.UseCors("AllowOrigin");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
