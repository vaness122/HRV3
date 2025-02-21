using HR.DAL.Data;
using HR.DAL.Repository;
using Microsoft.Data.SqlClient;
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
            var connectionString = "Server=localhost;Database=Bulky;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=True;TrustServerCertificate=True";

            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection failed: " + ex.Message);
                }
            }





            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider = new ServiceCollection()
                .AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer("Server=DESKTOP-AOJDK8M;Database=HRDb;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=True;TrustServerCertificate=True"))
                .AddScoped<IUserRepo, UserRepo>()
                .AddSingleton<HttpClient>(new HttpClient { BaseAddress = new Uri("https://localhost:7293/") })  // Point to the HR.API URL
                .BuildServiceProvider();

            var userRepo = serviceProvider.GetRequiredService<IUserRepo>();
            ApplicationConfiguration.Initialize();
            Application.Run(new Register(userRepo));
        }
    }
}
