
namespace VInquirer.Validators;
public interface IValidator
{
    bool Validate(string value);
    string GetErrorMessage();
}
