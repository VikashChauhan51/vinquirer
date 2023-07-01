using VInquirer.Console;
using VInquirer.Validators;

namespace VInquirer.Prompts;
public abstract class BasePrompt : IPrompt
{
    public string name { private set; get; }
    public string message { private set; get; }
    protected readonly IValidator? validator;
    protected readonly IScreenManager consoleRender;
    protected readonly InquirerSettings
      settings;
    public BasePrompt(string name, string message, InquirerSettings? settings, IValidator? validator = null, IScreenManager? consoleRender = null)
    {
        this.settings = settings ?? new InquirerSettings();
        this.name = name;
        this.message = message;
        this.validator = validator;
        this.consoleRender = consoleRender ?? new ConsoleManager();
    }

    public bool IsValidAnswer(string answer)
    {
        return validator?.Validate(answer) ?? true;
    }

    public abstract Parm[] GetQuestion();
    public abstract int[] Render();
    public abstract string Answer();
    public abstract void Ask();
}
