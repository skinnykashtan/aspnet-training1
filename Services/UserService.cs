using Microsoft.AspNetCore.Identity;
using Microsoft.JSInterop.Infrastructure;
using Web1.DTOs;
using Web1.Interfaces;
using Web1.Models;

namespace Web1.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly PasswordHasher<User> _passwordHasher;

    public UserService(IUserRepository context)
    {
        _userRepository = context;
        _passwordHasher = new PasswordHasher<User>();
    }


    public async Task<UserDto> CreateUserAsync(CreateUserDto dto)
    {
        var existingUser = _userRepository.GetByEmailAsync(dto.Email);

        if (existingUser != null)
        {
            throw new Exception("User already exists");
        }

        var user = new User();

        var hash = _passwordHasher.HashPassword(user, dto.Password);

        user.Username = dto.Username;
        user.Email = dto.Email;
        user.PasswordHash = hash;

        return new UserDto()
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email
        };
    }
}