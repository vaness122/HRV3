using HR.DAL.Data;
using HR.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace HR.Forms
{
    public static class Program
    {
        private static IUserRepo userRepo;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceProvider = new ServiceCollection()
     .AddDbContext<AppDbContext>(options =>
         options.UseSqlServer("Server=DESKTOP-AOJDK8M;Database=HRDb;Trusted_Connection=True;MultipleActiveResultSets=true;Encrypt=True;TrustServerCertificate=True"))
     .AddScoped<IUserRepo, UserRepo>()
     .BuildServiceProvider();

            var userRepo = serviceProvider.GetRequiredService<IUserRepo>();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Register(userRepo));
        }


    }
}