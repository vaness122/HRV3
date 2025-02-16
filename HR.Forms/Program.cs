using HR.DAL.Data;
using HR.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Net.Http;

namespace HR.Forms
{
    internal static class Program
    {
        private static IUserRepo userRepo;
        public static HttpClient HttpClient { get; } = new HttpClient();

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider = new ServiceCollection()
                .AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer("ServerDESKTOP-AOJDK8M;Database=HRDb;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=True;TrustServerCertificate=True"))
                .AddScoped<IUserRepo, UserRepo>()
                .AddSingleton<HttpClient>(new HttpClient { BaseAddress = new Uri("https://localhost:7293/") })  // Point to the HR.API URL
                .BuildServiceProvider();

            var userRepo = serviceProvider.GetRequiredService<IUserRepo>();
            ApplicationConfiguration.Initialize();
            Application.Run(new Register(userRepo));
        }
    }
}
