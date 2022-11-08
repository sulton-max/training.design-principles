using PrinciplesExamples.Models;

namespace PrinciplesExamples;

// Write code to solve problems, not to impress others
public class UserService    
{
    private UserRepository _userRepository = new UserRepository();

    // Kinda great one liner 
    public async Task<User?> GetById(int id) =>
        await Task.Run(() => _userRepository.Users.FirstOrDefault(x => x.Id == id));

    // Now that's good
    public async Task<User?> GetById2(int id)
    {
        if (id <= 0)
            throw new ArgumentException(nameof(id));

        return await Task.Run(() =>
        {
            return _userRepository.Users.FirstOrDefault(x => x.Id == id);
        });
    }
}