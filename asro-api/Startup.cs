using asro_api.Configuraion;
using asro_api.Data;
using asro_api.Data.Services;
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
using System.Linq;
using System.Threading.Tasks;

// https://www.youtube.com/watch?v=LgpC4tYtc6Y&t=1695s&ab_channel=MohamadLawand

namespace asro_api
{
    public class Startup
    {
        public string ConnectionString { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            ConnectionString = Configuration.GetConnectionString("DefaultConnectionString");
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<JwtConfig>(Configuration.GetSection("JwtConfig"));

            services.AddControllers();

            // Конфигурация DBContext в SQL
            //services.AddDbContext<AppDbContext>(options => options.UseSqlServer(ConnectionString));
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(
                    Configuration.GetConnectionString("DefaultConnectionString")));
            services.AddDefaultIdentity<IdentityUser>(opt =>
                {
                    // Обязательно цифры
                    opt.Password.RequireDigit = true;
                    opt.Password.RequiredLength = 5;
                    opt.Password.RequireUppercase = true;
                    opt.Lockout.MaxFailedAccessAttempts = 5;
                    opt.User.RequireUniqueEmail = true;
                    opt.SignIn.RequireConfirmedEmail = false;
                })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })

            .AddJwtBearer(jwt =>
             {
                 var key = System.Text.Encoding.ASCII.GetBytes(Configuration["JwtConfig:Secret"]);

                 jwt.SaveToken = true;
                 jwt.TokenValidationParameters = new TokenValidationParameters
                 {
                     // JWT Config
                     ValidateIssuerSigningKey = true,
                     IssuerSigningKey = new SymmetricSecurityKey(key),
                     ValidateIssuer = false,
                     ValidateAudience = false,
                     ValidateLifetime = true,
                     RequireExpirationTime = false
                 };
             });

            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //            .AddEntityFrameworkStores<AppDbContext>();

            // Конфигурация Сервиса
            services.AddTransient<thReports01Services>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "asro_api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "asro_api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Загрузка Seeds(Не являються правдой!)
            AppDbInitializer.Seed(app);
        }
    }
}
