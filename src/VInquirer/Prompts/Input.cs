using VInquirer.Console;
using VInquirer.Validators;

namespace VInquirer.Prompts;
public class Input : BasePrompt
{
    private string answer;
    private bool isValid = true;
    public Input(string name, string message, IValidator? validator = null, IScreenManager? consoleRender = null) : base(name, message, validator, consoleRender)
    {
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

    public override string[] GetQuestion()
    {
        return new[] { message };
    }

    public override int[] Render()
    {
        var bottomContent = new List<string>();
        if (!isValid && validator is not null) bottomContent.Add(validator!.GetErrorMessage());

        return consoleRender.Render(GetQuestion(), bottomContent.ToArray());
    }
}
