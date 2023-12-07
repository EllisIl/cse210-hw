using Discord.WebSocket;

class NameCall : SlashCommand
{
    public NameCall(DiscordSocketClient newClient) : base(newClient, "Makes fun of a user", "namecall")
    {
    }

    public override async Task Respond(SocketSlashCommand command)
    {
        await command.RespondAsync($"{command.User.Username} stinks!");
    }
}