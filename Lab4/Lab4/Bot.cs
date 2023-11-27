using Telegram.Bot;

namespace Lab4
{
    public class Bot
    {
        //https://api.telegram.org/bot6305630488:AAE00cd9vCJO8xcQfJYf7uqNPtMfmbyczBY
        //https://api.telegram.org/bot6902675845:AAHz_LvqMhTfrJGmng-EwanYMCHwD28yQHs/setWebhook?url=am3bohdanbot.azurewebsites.net
        private static TelegramBotClient? client { get; set; }
        public static async Task<TelegramBotClient> GetTelegramBot()
        {
            if (client != null)
            {
                return client;
            }
            client = new TelegramBotClient("6305630488:AAE00cd9vCJO8xcQfJYf7uqNPtMfmbyczBY");
            string hook = "https://f06c-178-212-111-119.ngrok.io";
            await client.SetWebhookAsync(hook);
            return client;
        }
    }
}
