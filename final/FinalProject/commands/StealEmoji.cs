using Discord;
using Discord.WebSocket;

class StealEmoji : SlashCommand
{
    public StealEmoji(DiscordSocketClient newClient): base(newClient, "Gets the source image of an emote", "steal"){}
}