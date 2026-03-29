using Microsoft.AspNetCore.Mvc;
using Web1.DTOs;
using Web1.Interfaces;

namespace Web1.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateUserDto dto)
    {
        try
        {
            var createdUser = await _userService.CreateUserAsync(dto);
            return Ok(createdUser);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var users= await _userService.GetAllAsync();
        return Ok(users);
    }
}