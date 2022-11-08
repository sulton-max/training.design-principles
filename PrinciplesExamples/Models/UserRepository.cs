namespace PrinciplesExamples.Models;

public class UserRepository
{
    public IQueryable<User> Users { get; set; }
}