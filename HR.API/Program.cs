using HR.DAL.Data;
using HR.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HR.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddTransient<DbContextOptions<AppDbContext>>();
            builder.Services.AddTransient<AppDbContext>(); 
            builder.Services.AddTransient<IUserRepo, UserRepo>();   
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:5173")
                         .AllowAnyMethod()
                         .AllowAnyHeader()
                         .AllowCredentials();
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
            app.MapFallbackToFile("index.html");
            app.UseStaticFiles();
            app.MapControllers();

            app.Run();
        }
    }
}
