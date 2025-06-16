namespace SmartOrders.UserService.Model;

public class User
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateOnly BirthDate { get; set; }
    public bool Active { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
}