
using System;
using System.Text;
using VInquirer.Console;
using VInquirer.Validators;

namespace VInquirer.Prompts;
public class PasswordInput : Input
{
    public PasswordInput(string name, string message, InquirerSettings? settings = null, IValidator? validator = null, IScreenManager? consoleRender = null) : base(name, message, settings, validator, consoleRender)
    {
    }

    protected override string GetUserAnswer()
    {
        var answer = new StringBuilder();
        var input = consoleRender.GetInputObservable();
        input.Intercept(true);
        input.TakeUntilEnter()
            .Subscribe(x =>
            {
                answer.Append(x.KeyChar);
                var currentColor = System.Console.ForegroundColor;
                var backgroundColor = System.Console.BackgroundColor;
                System.Console.ForegroundColor = settings.OptionTextColor;
                System.Console.BackgroundColor = settings.BackgroundColor;
                System.Console.Write('*');
                System.Console.ForegroundColor = currentColor;
                System.Console.BackgroundColor = backgroundColor;

            });

        return answer.ToString();
    }
}
