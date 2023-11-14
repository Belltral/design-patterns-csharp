using TestLibraries;

namespace DesignPatterns.Structural.Adapter.Validation
{
    public class EmailValidatorAdapter : IEmailValidator
    {
        public bool EmailValidator(string email)
        {
            return Validator.IsEmail(email);
        }
    }
}
