using System;
using core.Interfaces;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using core.Models;
using core.Services;

namespace core.Command
{
    /// <inheritdoc cref="ITelegramCommand"/>
    public class GetFactCommand : ITelegramCommand
    {
        /// <inheritdoc/>
        public string Name { get; } = "/getfact";

        /// <inheritdoc/>
        public async Task Execute(Message message, ITelegramBotClient client)
        {
            var chatId = message.Chat.Id;

            var httpHandler = new HttpHandler();
            CatResponse result = httpHandler.GetCatResponseAsync().GetAwaiter().GetResult();
            var text = result.Text;

            await client.SendTextMessageAsync(chatId, text);
        }

        /// <inheritdoc/>
        public bool Contains(Message message) => message.Type != MessageType.Text ? false : message.Text.Contains(Name);
    }
}
