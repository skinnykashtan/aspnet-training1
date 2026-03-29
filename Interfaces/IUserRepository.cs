using Web1.Models;

namespace Web1.Interfaces;

public interface IUserRepository
{
    Task<User> AddUserAsync(User user);
    Task<User> GetByEmailAsync(string email);
    Task<List<User>> GetAllAsync();
}