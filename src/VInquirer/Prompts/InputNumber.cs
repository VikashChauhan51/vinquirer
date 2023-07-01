using VInquirer.Console;
using VInquirer.Validators;

namespace VInquirer.Prompts;
public class InputNumber : Input
{
    public InputNumber(string name, string message, IScreenManager? consoleRender = null) : base(name, message, new NumericValidator(), consoleRender)
    {

    }
}
