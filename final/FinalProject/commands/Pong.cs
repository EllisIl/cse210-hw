using Discord.WebSocket;
class Pong : TextCommand
{
    public Pong(DiscordSocketClient newClient, string newCommandName, string newPrefix) : base(newClient, newCommandName, newPrefix)
    {
    }

    public async Task Respond(SocketSlashCommand command)
    {
        await command.RespondAsync($"Pong! Latency is {client.Latency}ms.");
    }
}