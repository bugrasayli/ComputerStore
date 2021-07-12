using Computer.Application.Mapper;
using Computer.Application.Repository;
using Computer.Infrastucture;
using Computer.Infrastucture.Mapper;
using Computer.Infrastucture.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace Computer.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        string policyName = "Pol";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ComputerContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddControllers();

            services.AddScoped<IRam, RamRepository>();

            services.AddScoped<IComputerMapper, ComputerMapper>();
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IGraphicCardMapper, GraphicCardMapper>();
            services.AddScoped<IRamMapper, RamMapper>();
            services.AddScoped<IComputer,ComputerRepository>();
            services.AddCors(opt => opt.AddPolicy(policyName, 
                policy => policy.AllowAnyHeader().AllowAnyOrigin()));
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            app.UseCors(policyName);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
