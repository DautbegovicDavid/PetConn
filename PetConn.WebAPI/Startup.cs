using AutoMapper;
using eProdaja.WebAPI.Security;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PetConn.Model;
using PetConn.Model.Requests;
using PetConn.WebAPI.Database;
using PetConn.WebAPI.Services;
using System.Collections.Generic;

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

            //services.AddDbContext<firstTryContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("PetCCon"))); lokalna konekcija

            services.AddDbContext<firstTryContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("Azure")));

            services.AddAuthentication("BasicAuth").AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuth", null);

            services.AddScoped<IKorisniciService, KorisniciService>();
            
            services.AddScoped<IVrstaPartneraService, VrstaPartneraService>();

            services.AddScoped<IService<Uloge, object>, BaseService<Uloge, object, Uloga>>();

            services.AddScoped<IPartneri<Partner, PartneriSearchRequest, PartneriUpsertRequest, PartneriUpsertRequest>, PartneriService/*<Partner, PartneriSearchRequest, PartneriUpsertRequest, PartneriUpsertRequest,Partneri>*/>();

            services.AddScoped<ICRUDService<Model.HelpModels.Drzava, DrzavaUpsert, DrzavaUpsert, DrzavaUpsert>,
                BaseCRUDService<Model.HelpModels.Drzava, DrzavaUpsert, DrzavaUpsert, DrzavaUpsert, Drzava>>();

            services.AddScoped<ICRUDService<Model.HelpModels.Grad, GradUpsert,GradUpsert, GradUpsert>,
                BaseCRUDService<Model.HelpModels.Grad,GradUpsert, GradUpsert, GradUpsert, Grad>>();
            services.AddScoped<ICRUDService<Model.Proizvodjac, object, ProizvodjacUpsertRequest, ProizvodjacUpsertRequest>,
                BaseCRUDService<Model.Proizvodjac, object, ProizvodjacUpsertRequest, ProizvodjacUpsertRequest,Database.Proizvodjac>>();

            services.AddScoped<ICRUDService<Model.HelpModels.JedinicaMjere, object, JedinicaMjereUpsertRequest, JedinicaMjereUpsertRequest>,
                BaseCRUDService<Model.HelpModels.JedinicaMjere, object, JedinicaMjereUpsertRequest, JedinicaMjereUpsertRequest, Database.JedinicaMjere>>();

            services.AddScoped<ICRUDService<VrstaProizvoda, object, VrstaProizvodaUpsertRequest, VrstaProizvodaUpsertRequest>,
                BaseCRUDService<VrstaProizvoda, object, VrstaProizvodaUpsertRequest, VrstaProizvodaUpsertRequest, Database.VrstaProizvodum>>();

            services.AddScoped<ICRUDService<Model.Poslovnica,PoslovnicaSearchRequest, PoslovnicaUpsertRequest, PoslovnicaUpsertRequest>,
                PoslovnicaService>();

            services.AddScoped<ICRUDService<Model.HelpModels.Lokacija, LokacijaSearchRequest, LokacijaUpsertRequest, LokacijaUpsertRequest>,
                LokacijaService>();
   
            services.AddScoped<IUposlenik<Model.Uposlenik, UposlenikSearchRequest,UposlenikUpsertRequest, UposlenikUpsertRequest>,
                UposlenikService>();

            services.AddScoped<IKorisniciUloge<Model.KorisniciUloge, KorisniciUlogeSearchRequest, KorisniciUlogeUpsertRequest, KorisniciUlogeUpsertRequest>,
                KorisniciUlogeService<Model.KorisniciUloge, KorisniciUlogeSearchRequest, KorisniciUlogeUpsertRequest, KorisniciUlogeUpsertRequest,Database.KorisniciUloge>>();

            services.AddScoped<ICRUDService<Model.Ljubimac, object, LjubimacUpsertRequest, LjubimacUpsertRequest>,
                BaseCRUDService<Model.Ljubimac, object, LjubimacUpsertRequest, LjubimacUpsertRequest, Database.Ljubimac>>();

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

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
