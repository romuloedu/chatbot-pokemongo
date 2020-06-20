using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using System.Threading;
using System.Threading.Tasks;

namespace ChatBot.PokemonGo.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext,
        CancellationToken cancellationToken)
        {
            string reply = $"Echo: {turnContext.Activity.Text}";

            await turnContext.SendActivityAsync(
                MessageFactory.Text(reply),
                cancellationToken
            );
        }
    }
}