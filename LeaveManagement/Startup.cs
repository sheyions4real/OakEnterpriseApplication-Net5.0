using LeaveManagement.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LeaveManagement.Application.Configurations;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Application.Repositories;
using Microsoft.AspNetCore.Identity.UI.Services;
using LeaveManagement.Services;
using Serilog;

namespace LeaveManagement
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDatabaseDeveloperPageExceptionFilter();



            // set the identity to use employee which inherits from the IdentityUser class
            services.AddDefaultIdentity<Employee>(options => options.SignIn.RequireConfirmedAccount = true) //setting RequireConfirmedAccount=false will not enforce email confirmation
                .AddRoles<IdentityRole>()               // defining the Identity to use IdentityRole
                .AddEntityFrameworkStores<ApplicationDbContext>();



            services.AddHttpContextAccessor(); // this service will allow u use the httpcontextaccessor object to access the login user and user emp id and department id
            // using papercut email server for test and development enviroment
            services.AddTransient<IEmailSender>(s => new EmailSender("localhost", 25, "no-reply-leave-mgt@oakpensions.com"));
            //services.AddTransient<ILeaveAllocationRepository, LeaveAllocationRepository>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();
             services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
            services.AddScoped<IEmployeeProfileRepository, EmployeeProfileRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();

            // metiond for 
            // AddScope         --- mixture of both. when its done it disposed g db connection
            // AddTransicent    --- Create a brand new copy of the class anytime its instantiated (HttpClient)
            //AddSingleton      --- A single instance of this class is created eg for logging


            services.AddAutoMapper(typeof(MapperConfig));


            // Add Serilog middle ware to Host in  Program.cs file for .net core 5.0
            // add seri log middleware in .net core 6
 
            //builder.Host.UseSerilog((ctx, lc) =>
            //lc.WriteTo.Console()
            //.ReadFrom.Configuration(ctx.Configuration));


            services.AddControllersWithViews();


          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSerilogRequestLogging();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
