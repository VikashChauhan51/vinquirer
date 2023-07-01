using VInquirer.Console;
using VInquirer.Validators;

namespace VInquirer.Prompts;
public class InputNumber : Input
{
    public InputNumber(string name, string message, InquirerSettings? settings = null, IValidator? validator = null, IScreenManager? consoleRender = null) : base(name, message, settings, validator ?? new NumericValidator(), consoleRender)
    {

    }
}
