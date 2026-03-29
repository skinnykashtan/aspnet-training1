using Web1.Data;
using Web1.Interfaces;
using Web1.Models;

namespace Web1.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public Task<User> AddAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetByEmailAsync(User user)
    {
        throw new NotImplementedException();
    }
}