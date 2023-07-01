using System.Net.Http.Headers;
using VInquirer.Console;
using VInquirer.Validators;

namespace VInquirer.Prompts;
public class Input : BasePrompt
{
    private string answer;
    protected bool isValid = true;
    public Input(string name, string message,
        InquirerSettings? settings = null,
        IValidator? validator = null,
        IScreenManager? consoleRender = null) :
        base(name, message, settings, validator, consoleRender)
    {
        answer = string.Empty;
    }

    public override string Answer()
    {
        return answer;
    }

    public override void Ask()
    {
        int[] pos = null;
        do
        {
            if (pos != null)
                consoleRender.Clean(0, pos[0]);

            pos = Render();

            answer = GetUserAnswer();

            isValid = IsValidAnswer(answer);

        } while (!isValid);

        consoleRender.Newline();
        consoleRender.Clean(0, 0);
    }

    protected virtual string GetUserAnswer()
    {
        return consoleRender.ReadLine();
    }

    public override Parm[] GetQuestion()
    {
        return new Parm[] { new Parm(message, settings.QuestionTextColor, settings.BackgroundColor) };
    }

    public override int[] Render()
    {
        var bottomContent = new List<Parm>();
        if (!isValid && validator is not null)
        {
            bottomContent.Add(new Parm(validator!.GetErrorMessage(), settings.ErrorTextColor, settings.BackgroundColor));
        }

        return consoleRender.Render(GetQuestion(), bottomContent.ToArray());
    }
}
