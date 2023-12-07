using Discord.WebSocket;

public abstract class TextCommand : Command
{
    protected string prefix;

    public TextCommand(DiscordSocketClient newClient, string newCommandName, string newPrefix) : base(newClient, newCommandName)
    {
        prefix = newPrefix;
    }
}
