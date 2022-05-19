using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using DAL;

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