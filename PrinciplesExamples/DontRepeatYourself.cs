using PrinciplesExamples.Models;

namespace PrinciplesExamples;

// Avoid repeating by algorithms or reusable solutions
public class EmloyeeService
{
    private UserRepository _userRepository = new UserRepository();
    private EmailService _emailService = new EmailService();

    public async Task<IEnumerable<User>> GetActiveEmployees()
    {
        return await Task.Run(() =>
        {
            return _userRepository.Users.Where(x => !x.IsDelete && x.Active).ToList();
        });
    }

    // This can be improved
    public async Task InviteActiveEmployees()
    {
        await Task.Run(() =>
        {
            _emailService.SendInvitation(_userRepository.Users.Where(x => x.Active).ToList(), "inviteURL");
        });
    }
    
    // That's better
    public async Task InviteActiveEmployees2()
    {
        await Task.Run(async () =>
        {
            _emailService.SendInvitation(await GetActiveEmployees(), "inviteURL");
        });
    }
}