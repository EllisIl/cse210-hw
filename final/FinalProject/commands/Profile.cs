using Discord;
using Discord.WebSocket;

class Profile : SlashCommand
{
    private readonly Random random;

    public Profile(DiscordSocketClient newClient) : base(newClient, "Gets the user's profile picture", "pfp")
    {
        random = new Random();
    }

    public override async Task Respond(SocketSlashCommand command)
    {
        var userOption = command.Data.Options?.FirstOrDefault(x => x.Name == "user");

        if (userOption == null || !(userOption.Value is SocketUser user))
        {
            // If no user is provided, use the user who executed the command
            user = command.User;
        }

        // Get the URL of the user's avatar (profile picture)
        string avatarUrl = user.GetAvatarUrl() ?? user.GetDefaultAvatarUrl();

        // Generate a random color for the embed
        var color = new Color(random.Next(256), random.Next(256), random.Next(256));

        // Respond with the user's avatar URL and a random color
        var embed = new EmbedBuilder()
            .WithTitle($"{user.Username}'s Profile Picture")
            .WithImageUrl(avatarUrl)
            .WithColor(color)
            .Build();

        await command.RespondAsync(embeds: new[] { embed });
    }
}