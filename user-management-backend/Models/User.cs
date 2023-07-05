namespace user_management_backend.Models;

public class User
{
    public int Id { get; set; }
    
    public required string firstName { get; set; }

    public required string lastName { get; set; }

    public required string email { get; set; }
}