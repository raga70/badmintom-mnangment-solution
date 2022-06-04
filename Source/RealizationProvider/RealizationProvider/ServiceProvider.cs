using DAL;
using Microsoft.Extensions.DependencyInjection;

namespace RealizationProvider;

public static class serviceProviderrr
{
    public static IServiceCollection Get()
    {
        var services = new ServiceCollection();

        services.AddSingleton<IUserDB>(new UserDB());
        services.AddSingleton<ITournamentDB>(new TournamentDB());
        services.AddSingleton<IGameDB>(new GameDB());
        return services;
    }
}