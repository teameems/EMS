using BaseLibrary.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ServerLibrary.Repositories.Contracts;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
[AllowAnonymous]
public class AuthenticationController(IUserAccount accountInterface) : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> CreateAsync(Register user)
    {
        if (user == null) return BadRequest("User is null");
        var result = await accountInterface.CreateAsync(user);
        return Ok(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync(Login user)
    {
        if (user == null) return BadRequest("User is null");
        var result = await accountInterface.SigninAsync(user);
        return Ok(result);
    }

    [HttpPost("refresh-token")]
    public async Task<IActionResult> RefreshTokenAsync(RefreshToken refreshToken)
    {
        if (refreshToken == null) return BadRequest("Refresh token is null, Model is empty!");
         var result = await accountInterface.RefreshTokenAsync(refreshToken);
         return Ok(result);
        
    }
}