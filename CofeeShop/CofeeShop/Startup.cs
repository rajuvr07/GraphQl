using CofeeShop.Interfaces;
using CofeeShop.Mutation;
using CofeeShop.Query;
using CofeeShop.Schema;
using CofeeShop.Services;
using CofeeShop.Type;
using GraphiQl;

using GraphQL.Server;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CofeeShop
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        //[Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSingleton<IProduct, ProductServices>();
            services.AddSingleton<ProductType>();
            services.AddSingleton<ProductQuery>();
            services.AddSingleton<ProductMutataion>();
            services.AddSingleton<ISchema, ProductSchema>();
            services.AddGraphQL(options =>
            {
                options.EnableMetrics = false;
            }).AddSystemTextJson();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseGraphiQl("/graphql");
            app.UseGraphQL<ISchema>();
         
        }
    }
}
