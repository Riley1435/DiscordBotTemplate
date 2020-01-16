using System;
using System.Reflection;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;

namespace DiscordBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection()
                .AddSingleton(new DiscordSocketClient())
                .AddSingleton(new CommandService())
                .BuildServiceProvider();

            var bot = new Bot(services,
                services.GetService<DiscordSocketClient>(),
                services.GetService<CommandService>());

            bot.RunAsync().GetAwaiter().GetResult();
        }
    }
}
