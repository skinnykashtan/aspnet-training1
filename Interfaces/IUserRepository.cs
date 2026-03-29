using Web1.Models;

namespace Web1.Interfaces;

public interface IUserRepository
{
    Task<User> AddAsync(User user);
    Task<User> GetByEmailAsync(User user);
}