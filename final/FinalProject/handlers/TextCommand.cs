using Discord;
using Discord.Net;
using Discord.WebSocket;

class TextCommand : Command
{
    private string prefix;
    public TextCommand(DiscordSocketClient newClient, string newCommandName, string newPrefix) : base(newClient, newCommandName){
        prefix = newPrefix;
    }
}