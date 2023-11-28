using Discord.Rest;
using Discord.WebSocket;

class Profile : SlashCommand
{
    public Profile(DiscordSocketClient newClient): base(newClient, "Gets the user's profile picture", "pfp"){}
}