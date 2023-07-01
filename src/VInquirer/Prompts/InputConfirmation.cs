using VInquirer.Console;
using VInquirer.Validators;

namespace VInquirer.Prompts;
public class InputConfirmation : Input
{
    public InputConfirmation(string name, string message, InquirerSettings? settings = null, IScreenManager? consoleRender = null) : base(name, message, settings, new RegexValidator(@"^(?:y\b|n\b)"), consoleRender)
    {

    }

    public override Parm[] GetQuestion()
    {
        return new Parm[] { new Parm($"{message} (y/n)", settings.QuestionTextColor, settings.BackgroundColor) };
    }
}
