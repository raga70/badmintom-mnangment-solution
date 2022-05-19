using DAL;
using Microsoft.Extensions.DependencyInjection;
using RealizationProvider;

namespace WFA;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    private static readonly IServiceCollection _services = serviceProviderrr.Get();

    private static readonly IServiceProvider _provider = _services.BuildServiceProvider();


    [STAThread]
    private static void Main()
    {
        var gameDb = _provider.GetService<IGameDB>();
        var tournamentDb = _provider.GetService<ITournamentDB>();
        var userDb = _provider.GetService<IUserDB>();
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1(userDb, gameDb, tournamentDb));
    }
}