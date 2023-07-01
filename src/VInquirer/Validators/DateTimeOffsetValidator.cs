
namespace VInquirer.Validators;
public class DateTimeOffsetValidator : IValidator
{
    public bool Validate(string value)
    {

        return DateTimeOffset.TryParse(value, out _);
    }

    public string GetErrorMessage()
    {
        return "Answer accepts only dates.";
    }
}
