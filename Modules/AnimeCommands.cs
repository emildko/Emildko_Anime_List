using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emildko_Anime_List.Modules
{
    public class AnimeCommands : ModuleBase
    {
        static Random rnd = new Random();
        public static List<(string, string, string)> anime;
        public static List<(string, string, string)> anime10;
        public static List<(string, string, string)> anime9;
        public static List<(string, string, string)> anime8;
        public static List<(string, string, string)> anime7;
        public static List<(string, string, string)> anime6;
        [Group("anime")]
        public class AnimeModule : ModuleBase<SocketCommandContext>
        {
            [Command("help")]
            public async Task HelpCommand()
            {
                var sb = new StringBuilder();


                sb.AppendLine("Hello and welcome Emildko's Anime Guide");
                sb.AppendLine("I'm here to help YOU find your next anime, all functions are called by !anime [command], Here's a list of things you can do:");
                sb.AppendLine(" ");
                sb.AppendLine("1. suggestion");
                sb.AppendLine("I've given many of the animes I've seen a score from 1-10, however for now, i've only added so that you can search for animes ranked 6 or higher, why would you wanna watch anything below that score anyways?");
                sb.AppendLine("You can use this function by writing \"!anime suggestion 10\" or any other number");
                sb.AppendLine(" ");
                sb.AppendLine("2. random");
                sb.AppendLine("Here you will simple recieve a random anime from my list, with no thought of score, I've seen a lot of shit, so use with caution");
                sb.AppendLine("You can use this function by writing \"!anime random\"");

                await ReplyAsync(sb.ToString());
            }

            [Command("suggestion")]
            public async Task SuggestionCommand(int num)
            {
                var sb = new StringBuilder();
                switch (num)
                {
                    case 10:
                        int r10 = rnd.Next(anime10.Count - 1);
                        sb.Append("Hmmm... I suggest you watch " + anime10[r10].Item1);
                        sb.AppendLine(" ");
                        sb.Append("https://myanimelist.net/anime/" + anime10[r10].Item3);
                        break;
                    case 9:
                        int r9 = rnd.Next(anime9.Count - 1);
                        sb.Append("Hmmm... I suggest you watch " + anime9[r9].Item1);
                        sb.AppendLine(" ");
                        sb.Append("https://myanimelist.net/anime/" + anime9[r9].Item3);
                        break;
                    case 8:
                        int r8 = rnd.Next(anime8.Count - 1);
                        sb.Append("Hmmm... I suggest you watch " + anime8[r8].Item1);
                        sb.AppendLine(" ");
                        sb.Append("https://myanimelist.net/anime/" + anime8[r8].Item3);
                        break;
                    case 7:
                        int r7 = rnd.Next(anime7.Count - 1);
                        sb.Append("Hmmm... I suggest you watch " + anime7[r7].Item1);
                        sb.AppendLine(" ");
                        sb.Append("https://myanimelist.net/anime/" + anime7[r7].Item3);
                        break;
                    case 6:
                        int r6 = rnd.Next(anime6.Count - 1);
                        sb.Append("Hmmm... I suggest you watch " + anime6[r6].Item1);
                        sb.AppendLine(" ");
                        sb.Append("https://myanimelist.net/anime/" + anime6[r6].Item3);
                        break;
                }
                await ReplyAsync(sb.ToString());
            }

            [Command("random")]
            public async Task RandomCommand()
            {
                var sb = new StringBuilder();


                sb.AppendLine("Warning, you've chosen random, I've seen a lot of trash and you might see some too, I take no responsibility for what you might see");
                sb.AppendLine("But as you're probably a degenerate like me, here you go:");
                sb.AppendLine(anime[rnd.Next(anime6.Count - 1)].Item1);

                await ReplyAsync(sb.ToString());
            }
        }
    }
}
