
using System.Text;
using VInquirer.Console;
using VInquirer.Validators;

namespace VInquirer.Prompts;
public class PasswordInput : Input
{
    public PasswordInput(string name, string message, IValidator? validator = null, IScreenManager? consoleRender = null) : base(name, message, validator, consoleRender)
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
                System.Console.Write('*');
            });

        return answer.ToString();
    }
}
