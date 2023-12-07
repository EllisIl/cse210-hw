using Discord;
using Discord.Net;
using Discord.WebSocket;
using Newtonsoft.Json;

abstract public class SlashCommand : Command
{
    private string commandDesc;

    public SlashCommand(DiscordSocketClient newClient, string newCommandDesc, string newCommandName) : base(newClient, newCommandName)
    {
        commandDesc = newCommandDesc;
    }

    public async Task CreateCommand()
    {
        var guild = client.GetGuild(924825389061275659);

        var guildCommand = new SlashCommandBuilder();
        guildCommand.WithName(commandName);
        guildCommand.WithDescription(commandDesc);

        try
        {
            await guild.CreateApplicationCommandAsync(guildCommand.Build());
            Console.WriteLine($"Added {commandName} command");
        }
        catch (HttpException exception)
        {
            var json = JsonConvert.SerializeObject(exception.Errors, Formatting.Indented);
            Console.WriteLine(json);
        }
    }

    abstract public Task Respond(SocketSlashCommand command);
}