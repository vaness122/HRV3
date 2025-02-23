using HR.DAL.Data;
using HR.DAL.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HR.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddTransient<AppDbContext>();
            builder.Services.AddTransient<IUserRepo, UserRepo>();

            builder.Services.AddTransient<IEmployeeRepo, EmployeeRepo>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            
            var provider = builder.Services.BuildServiceProvider();
            var configuration = provider.GetRequiredService<IConfiguration>();
            builder.Services.AddCors(options =>
                {
                    var frontendURL = configuration.GetValue<string>("frontend_url");
                    options.AddDefaultPolicy(builder =>
                    {
                        builder.WithOrigins(frontendURL)
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                        

                    });

                });



            var app = builder.Build();
          

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors();

            app.UseAuthorization();

            app.UseStaticFiles();
            app.MapControllers();
        

            app.Run();
        }
    }
}
