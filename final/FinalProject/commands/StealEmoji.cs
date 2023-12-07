using Discord;
using Discord.WebSocket;

class StealEmote : SlashCommand
{
    private readonly Random random;

    public StealEmote(DiscordSocketClient newClient) : base(newClient, "Gets the source of a Discord emote", "emote")
    {
        // Initialize the Random object
        random = new Random();
    }

    public override async Task Respond(SocketSlashCommand command)
{
    var emoteOption = command.Data.Options?.FirstOrDefault(x => x.Name == "emote") as SocketSlashCommandDataOption;

    if (emoteOption != null)
    {
        // Generate a random color for the embed
        var color = new Color(random.Next(256), random.Next(256), random.Next(256));
        // Respond with the emote URL and a random color
        var embed = new EmbedBuilder()
            .WithTitle($"Source of Emote: {emoteOption.Value}")
            .WithImageUrl(emoteOption.Value as string)
            .WithColor(color)
            .Build();
        await command.RespondAsync(embeds: new[] { embed });
    }
    else
    {
        // Handle the case where emoteOption is null or Value is not a string
        await command.RespondAsync("Invalid or missing emote option.");
    }
}
}