using VInquirer.Console;
using VInquirer.Validators;

namespace VInquirer.Prompts;
public class InputConfirmation : Input
{
    public InputConfirmation(string name, string message, IScreenManager? consoleRender = null) : base(name, message, new RegexValidator(@"^(?:y\b|n\b)"), consoleRender)
    {

    }

    public override string[] GetQuestion()
    {
        return new[] { $"{message} (y/n)" };
    }
}
