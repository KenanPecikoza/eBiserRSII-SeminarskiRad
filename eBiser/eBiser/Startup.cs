using eBiser.Configuration;
using eBiser.Data.Requests;
using eBiser.Database;
using eBiser.Fillters;
using eBiser.Security;
using eBiser.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBiser
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
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "eBiser Api", Version = "v1" });

                options.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = JwtBearerDefaults.AuthenticationScheme
                            }
                        },
                        new string[] {}
                    }
                });
            });

            // Authentication
            services
               .AddAuthentication(x =>
               {
                   x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                   x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
               })
               .AddJwtBearer(config =>
               {
                   var secKey = Configuration.GetSection(nameof(AppSettings)).Get<AppSettings>();
                   config.SaveToken = true;
                   config.RequireHttpsMetadata = false;

                   /* config.Events = new JwtBearerEvents()
                    {
                        OnMessageReceived = context =>
                        {
                            if (context.Request.Query.ContainsKey("access_token"))
                            {
                                context.Token = context.Request.Query["access_token"];
                            }

                            return Task.CompletedTask;
                        }
                    };*/

                   config.TokenValidationParameters = new TokenValidationParameters()
                   {
                       ClockSkew = TimeSpan.Zero,
                       ValidateIssuer = false,
                       ValidateAudience = false,
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secKey.Secret)),
                   };
               });


            services.AddHttpClient()
             .AddHttpContextAccessor();
            services.AddControllers();
            //services.AddScoped <ICRUDService<Data.Obavijest, ObavijestSearchRequest, ObavijestInsertRequest, ObavijestInsertRequest>,BaseCRUDService<Data.Obavijest,ObavijestSearchRequest, Obavijest, ObavijestInsertRequest, ObavijestInsertRequest>>();
            services.AddScoped<ICRUDService<Data.Obavijest, ObavijestSearchRequest, ObavijestInsertRequest, ObavijestInsertRequest>, ObavijestService>();
            services.AddScoped<ICRUDService<Data.Clanarina, ClanarinaSearchRequest, ClanarinaUpsertRequest, ClanarinaUpsertRequest>, ClanarineService>();
            services.AddScoped<ICRUDService<Data.UlaznaSredstva, UlaznaSredstvaSearchRequest, UlaznaSredstvaUpsertRequest, UlaznaSredstvaUpsertRequest>, UlaznaSredstvaService>();
            services.AddScoped<ICRUDService<Data.IzlaznaSredstva, IzlaznaSredstvaSearchRequest, IzlaznaSredstvaUpsertRequest, IzlaznaSredstvaUpsertRequest>, IzlaznaSredstvaService>();
            services.AddScoped<ICRUDService<Data.Projekti, ProjektiSearchRequest, ProjektiUpsertRequest, ProjektiUpsertRequest>, ProjektiService>();
            services.AddScoped<ICRUDService<Data.AkcijePomoci, AkcijePomociSearchRequest, AkcijePomociUpsertRequest, AkcijePomociUpsertRequest>, AkcijePomociService>();
            services.AddScoped<ICRUDService<Data.Sastanak, SastanakSearchRequest, SastanakUpsertRequest, SastanakUpsertRequest>, SastanakService>();
            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<ICRUDService<Data.Donacije, DonacijeSearchRequest, DonacijeUpsertRequest, DonacijeUpsertRequest>, DonacijeService>();
            services.AddScoped<ICRUDService<Data.ObavijestOcjena, ObavijestOcjenaSearchRequest, ObavijestOcjenaUpsertRequest, ObavijestOcjenaUpsertRequest>, ObavijestiOcjenaService>();
            services.AddScoped<IService<Data.DjelatnostOsoblje, object>, BaseService<Data.DjelatnostOsoblje, object, DjelatnostOsoblje>>();


            services.AddScoped<IService<Data.ObavijestKategorija, object>, BaseService<Data.ObavijestKategorija, object, ObavijestKategorija>>();
            services.AddScoped<ISecurityService, SecurityService>();

            services.AddScoped<IRecommendService, RecommendService>();




            services.AddScoped<IAuthorizationHandler, JwtRequirementHandler>();

            services.Configure<AppSettings>(Configuration.GetSection(nameof(AppSettings)));


            services.AddAutoMapper(typeof(Helper.Mapper));
            services.AddMvc(x => x.Filters.Add<ErrorFilter>());
            // DB Connection
            services.AddDbContext<eBiserContext>(x =>
                x.UseSqlServer(Configuration.GetConnectionString("eBiser")));


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = "";
            });


            //app.UseHttpsRedirection();

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
