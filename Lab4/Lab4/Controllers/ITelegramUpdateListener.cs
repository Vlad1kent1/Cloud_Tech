using Telegram.Bot.Types;

namespace Lab4.Controllers
{
    public interface ITelegramUpdateListener
    {
        Task GetUpdate(Update update);
    }
}