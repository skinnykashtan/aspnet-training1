using Web1.Enums;

namespace Web1.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string Email { get; set; }
    public UserRole RoleType { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}