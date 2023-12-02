using Discord;
using Discord.WebSocket;

class Pong : TextCommand
{
    string userName;

    public Pong(DiscordSocketClient newClient, string newCommandName, string newPrefix) : base(newClient, newCommandName, newPrefix) {

    }
}