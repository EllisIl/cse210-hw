using System;
using Discord;
using Discord.WebSocket;

class Program
{
    public static void Main(string[] args) => new Program().StartBot().GetAwaiter().GetResult();

    private DiscordSocketClient _client;

    public async Task StartBot()
    {
        _client = new DiscordSocketClient();

        var token = File.ReadAllText("token.txt");

        await _client.LoginAsync(TokenType.Bot, token);
        await _client.StartAsync();

        _client.Ready += Client_Ready;
        _client.SlashCommandExecuted += SlashCommandHandler;
        _client.Ready += () =>
        {
            Console.WriteLine("Connected to Discord");
            return Task.CompletedTask;
        };
        await Task.Delay(-1);
    }

    public async Task Client_Ready()
    {
        Profile profileCommand = new(_client);
        await profileCommand.CreateCommand();
    }

    private Task Log(LogMessage msg)
    {
        Console.WriteLine(msg.ToString());
        return Task.CompletedTask;
    }
    private async Task SlashCommandHandler(SocketSlashCommand command)
    {
        await command.RespondAsync($"You executed {command.Data.Name}");
    }
}