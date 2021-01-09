using AutoMapper;
using eProdaja.WebAPI.Security;
using Microsoft.AspNetCore.Authentication;
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
using PetConn.WebAPI.Database;
using PetConn.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI
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
            services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            ); // rijesi problem sa mapiranjem i internal 500 greskom, ignora loopanje json objekata
            //services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PetConn.WebAPI", Version = "v1" });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "http"
                            },
                            Scheme = "basic",
                            Name = "basic",
                            In = ParameterLocation.Header,

                        },
                        new List<string>()//da bude na svakom kontrolleru
                    }
                });
                c.AddSecurityDefinition("http", new OpenApiSecurityScheme
                {
                    Description = "heheheh",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"

                });
            });
           
            services.AddAutoMapper(typeof(Startup));

            services.AddDbContext<firstTryContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("PetCCon")));

            services.AddAuthentication("BasicAuth").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuth", null);

            //services.AddScoped<ICRUDService<Model.Korisnik, Model.Requests.KorisnikSearchRequest, Model.Requests.KorisnikUpsertRequest, Model.Requests.KorisnikUpsertRequest>,
            //    KorisniciService>();//zbog osnovnih crud mi treba ovaj

            services.AddScoped<IKorisniciService, KorisniciService>();//zbog auth mi treba ovaj a samim tim  i za postavljanje projekta

            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Uloga>>();
            services.AddScoped<IService<Model.VrstePartnera, object>, BaseService<Model.VrstePartnera, object, VrstaPartnera>>();

            services.AddScoped<ICRUDService<Model.HelpModels.Drzava, Model.Requests.DrzavaUpsert, Model.Requests.DrzavaUpsert, Model.Requests.DrzavaUpsert>,
                BaseCRUDService<Model.HelpModels.Drzava, Model.Requests.DrzavaUpsert, Model.Requests.DrzavaUpsert, Model.Requests.DrzavaUpsert, Drzava>>();

            services.AddScoped<ICRUDService<Model.HelpModels.Grad, Model.Requests.GradUpsert, Model.Requests.GradUpsert, Model.Requests.GradUpsert>,
                BaseCRUDService<Model.HelpModels.Grad, Model.Requests.GradUpsert, Model.Requests.GradUpsert, Model.Requests.GradUpsert, Grad>>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PetConn.WebAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();//kazemo apiju da koristimo authentifikaciju

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}