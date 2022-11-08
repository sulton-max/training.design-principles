namespace PrinciplesExamples.Models;

public class User
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;
    
    public string Username { get; set; } = null!;
    public bool Active { get; set; }
    public bool IsDelete { get; set; }
}