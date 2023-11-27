using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace Lab4.Controllers.Commands
{
    public class InlineCommand : ICommand
    {
        public TelegramBotClient Client => Bot.GetTelegramBot().Result;

        public string Name => "/inline";


        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;


            var inlineKeyboard = new InlineKeyboardMarkup(new[] {
                new [] {
                    InlineKeyboardButton.WithUrl("facebook", "https://www.facebook.com/"),
                    InlineKeyboardButton.WithUrl("telegram", "https://web.telegram.org/")
            },
                new [] {
                    InlineKeyboardButton.WithCallbackData("item1"),
                    InlineKeyboardButton.WithCallbackData("item2"),
            },
         });

            await Client.SendTextMessageAsync(
            chatId: chatId,
            text: "Виберіть пункт меню: ",
                replyMarkup: inlineKeyboard
                );
        }



    }
}
