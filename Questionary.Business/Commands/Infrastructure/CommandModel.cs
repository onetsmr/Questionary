namespace Questionary.Business.Commands.Infrastructure
{
    public class CommandModel
    {
        public CommandModel(object data, string systemMessage = null)
        {
            Data = data;
            SystemMessage = systemMessage;
        }

        public object Data { get; private set; }

        public string SystemMessage { get; private set; }
    }
}
