using Questionary.Business.Commands.Infrastructure;
using Questionary.Domain;
using Questionary.Domain.Enums;
using Questionary.Resources;
using Questionary.UI.Screens.Infrastructure;
using Questionary.Utils;

namespace Questionary.UI.Screens
{
    public abstract class QuestionScreenBase : Screen
    {
        protected QuestionScreenBase(IScreenRender screenRender, CommandModel model)
            : base(screenRender, model)
        {
        }

        protected override CommandTypeEnum[] GetAllowedCommands()
        {
            return new[]
            {
                CommandTypeEnum.Answer
            };
        }

        public override void Render()
        {
            var question = Model.Data.As<Question>();

            ScreenRender.WriteLine(Text.QuestionScreen.Header,
                question.Number,
                question.QuestionForm.Questions.Count);

            ScreenRender.WriteLine(question.Description);

            RenderSystemMessage(Model.SystemMessage);
        }
    }
}
