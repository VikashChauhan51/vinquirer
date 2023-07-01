
namespace VInquirer.Validators;
public class NumericValidator : IValidator
{
    public bool Validate(string value)
    {
        return double.TryParse(value, out _);
    }

    public string GetErrorMessage()
    {
        return "Answer accepts only numbers.";
    }
}
