using HypernovaGastos.Data;
using HypernovaGastos.Models;
using HypernovaGastos.Models.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HypernovaGastos
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            var key = Configuration["TokenKey"];

            //Configuracion de Cors , para permitir los origines
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.AllowAnyOrigin()
                                             .AllowAnyMethod()
                                             .AllowAnyHeader();
                                  });
            });

            services.AddControllers()
           .AddNewtonsoftJson(options =>
           options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

           
            //Configuracion de Swagger para la visualizar la informacion de la API
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "HypernovaLabs",
                    Version = "v1",
                    Description = "Esta es una API ,para gestionar los gastos de la empresa",
                    TermsOfService = new Uri("https://hypernovalabs.com/es/"),
                    Contact = new OpenApiContact()
                    {
                        Name = "Carlos Quintero",
                        Email = "cquinterogrande@yahoo.es",
                        Url = new Uri("https://my-site-caqg.netlify.app/")
                    }
                });
            });


            //Configuramos los DbContext con la conexion a la BD
            var connectionHypernova = Configuration.GetConnectionString("HypernovaLabsConection");
            services.AddDbContext<HYPERNOVALABSContext>(options => options.UseSqlServer(connectionHypernova));
            services.AddDbContext<HYPERNOVALABSAuthContext>(options => options.UseSqlServer(connectionHypernova));
            
            //Habilitamos el uso de Identity
            services.AddIdentity<ApplicationUser, IdentityRole>()
                   .AddEntityFrameworkStores<HYPERNOVALABSAuthContext>()
                   .AddDefaultTokenProviders();


            services.AddScoped<SpGastosRepository>();
            services.AddScoped<SpEmpleadosRepository>();
            //Configuramos el uso de Tokens con JWTokens
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                    ValidateIssuer = false,
                    RequireExpirationTime = false,
                    ValidateLifetime = true,
                    ValidateAudience = false,
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(MyAllowSpecificOrigins);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HypernovaGastos v1"));
            }

            app.UseHttpsRedirection();
            app.UseResponseCaching();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
