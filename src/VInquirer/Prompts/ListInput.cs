
using System.Reactive.Linq;
using VInquirer.Console;
using VInquirer.Validators;

namespace VInquirer.Prompts;
public class ListInput : BasePrompt
{
    private string answer;
    private int selectedOption = 0;
    private string[] options;
    public ListInput(string name, string message, string[] options,
        InquirerSettings? settings = null,
        IValidator? validator = null,
        IScreenManager? consoleRender = null) :
        base(name, message, settings, validator, consoleRender)
    {
        this.options = options;
        this.answer = string.Empty;
    }

    public override string Answer()
    {
        return answer;
    }

    public override void Ask()
    {
        var pos = Render();
        var input = consoleRender.GetInputObservable();
        input.Intercept(true);
        input.KeyPress()
            .TakeUntil(input.GetEnterObservable())
            .Where(x => x.Key == ConsoleKey.UpArrow || x.Key == ConsoleKey.DownArrow)
            .Subscribe(x =>
            {
                if (x.Key == ConsoleKey.UpArrow)
                {
                    if (selectedOption > 0) selectedOption--;
                }
                else
                {
                    if (selectedOption < options.Length - 1) selectedOption++;
                };
                consoleRender.Clean(0, pos[0]);
                pos = Render();
            });
        answer = (selectedOption + 1).ToString();
    }

    public override Parm[] GetQuestion()
    {
        var question = new string[options.Length + 1];
        question[0] = message;
        options.CopyTo(question, 1);

        question[selectedOption + 1] = "> " + question[selectedOption + 1];

        var parm = new Parm[options.Length + 1];
        for (int i = 0; i < question.Length; i++)
        {
            parm[i] = new Parm(question[i], i == 0 ? settings.QuestionTextColor : i == (selectedOption + 1) ? settings.SelectedOptionTextColor: settings.OptionTextColor, settings.BackgroundColor);
        }

        return parm;
    }

    public override int[] Render()
    {
        return consoleRender.Render(GetQuestion(), new Parm[] { });
    }
}
