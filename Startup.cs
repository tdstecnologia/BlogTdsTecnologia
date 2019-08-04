using BlogTdsTecnologia.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlogTdsTecnologia
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddEntityFrameworkNpgsql()
         .AddDbContext<Persistencia>(options => options.UseNpgsql(Configuration.GetConnectionString("BlogPostgreSQLDB")));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes => routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}"));


        }
    }
}
