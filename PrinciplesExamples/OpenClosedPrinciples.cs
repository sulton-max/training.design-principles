namespace PrinciplesExamples;

// Objects or entities should be open for extension but closed for modification
// Inheritance and extension methods to help
public abstract class AuthenticationService
{
    public bool CheckPassword(string email, string password)
    {
        // Get the user
        // Check the password
    }
}


public class AdvancedAuthenticationService : AuthenticationService
{
    // We need to validate new password
    public bool ValidateNewPassword(string newPassword)
    {
        // Check for length, numbers, chars
    }
}