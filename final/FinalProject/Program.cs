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

        _client.Ready += CreateCommands;
        _client.SlashCommandExecuted += SlashCommandHandler;
        _client.Ready += () =>
        {
            Console.WriteLine("Connected to Discord");
            return Task.CompletedTask;
        };
        await Task.Delay(-1);
    }

    public async Task CreateCommands()
    {
        StealEmote emote = new(_client);
        Pong pong = new(_client, "pong", "!");
        NameCall nameCall = new(_client);

        await emote.CreateCommand();
        await nameCall.CreateCommand();
    }

    private async Task SlashCommandHandler(SocketSlashCommand command)
    {
        Profile profile = new(_client);
        StealEmote emote = new(_client);
        Pong pong = new(_client, "pong", "!");
        NameCall nameCall = new(_client);

        switch (command.Data.Name)
        {
            case "pfp":
                await profile.Respond(command);
                break;
            case "emote":
                await emote.Respond(command);
                break;
            case "pong":
                await pong.Respond(command);
                break;
            case "namecall":
                await nameCall.Respond(command);
                break;
        }
    }
}