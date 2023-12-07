using Discord.WebSocket;

abstract public class Command
{
    protected DiscordSocketClient client;
    protected string commandName;

    public Command(DiscordSocketClient newClient, string newCommandName)
    {
        commandName = newCommandName;
        client = newClient;
    }
}