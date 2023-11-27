using Lab4.Controllers.Commands;
using Telegram.Bot.Types;

namespace Lab4.Controllers
{
    public class CommandExecutor : ITelegramUpdateListener
    {
        private List<ICommand> commands;
        public CommandExecutor()
        {
            commands = new List<ICommand>()
            {
                new StartCommand(),
                new InlineCommand(),
                new KeyboardCommand()
            };
        }
        public async Task GetUpdate(Update update)
        {
            Message msg = update.Message;
            ICommand searchCommand = commands.FirstOrDefault(command => command.Name == msg.Text);
            if (searchCommand != null)
            {
                await searchCommand.Execute(update);
            }
            else
                await new NotFoundCommand().Execute(update);
        }
    }
}
