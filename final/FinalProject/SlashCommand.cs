using Discord;
using Discord.Net;
using Discord.WebSocket;
using Newtonsoft.Json;

public class SlashCommand : Command
{
    public DiscordSocketClient client;
    private string commandDesc;

    public SlashCommand(DiscordSocketClient newClient, string newCommandDesc, string newCommandName) : base(newCommandName){
        client = newClient;
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
        catch(HttpException exception)
        {
            var json = JsonConvert.SerializeObject(exception.Errors, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}