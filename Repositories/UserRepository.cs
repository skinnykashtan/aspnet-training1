using Microsoft.EntityFrameworkCore;
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

    public async Task<User> AddUserAsync(User user)
    {
        await _context.AddAsync(user);
        await _context.SaveChangesAsync();

        return user;
    }

    public async Task<User> GetByEmailAsync(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
    }
}