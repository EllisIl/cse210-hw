using Discord;
using Discord.WebSocket;

class NameCall : SlashCommand
{
    public NameCall(DiscordSocketClient newClient): base(newClient, "Makes fun of a user", "namecall"){}
}