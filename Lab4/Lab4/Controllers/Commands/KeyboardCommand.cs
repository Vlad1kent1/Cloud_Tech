using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace Lab4.Controllers.Commands
{
    public class KeyboardCommand : ICommand
    {
        public TelegramBotClient Client => Bot.GetTelegramBot().Result;

        public string Name => "/keyboard";

        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;


            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new [] {
                    new KeyboardButton ( "Привіт"),
                    new KeyboardButton ( "Як справи?"),
                },
                new [] {
                    new KeyboardButton ( "Контакт") {RequestContact = true },
                    new KeyboardButton ( "Геолокація") {RequestLocation = true },
                },

            });


            await Client.SendTextMessageAsync(
                chatId: update.Message.Chat.Id,
                text: "Choose a response",
                replyMarkup: replyKeyboardMarkup);
        }

    }
}
