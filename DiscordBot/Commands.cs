using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("points")]
        public async Task Points()
        {
            await ReplyAsync("You have 10 points");
        }
    }
}
