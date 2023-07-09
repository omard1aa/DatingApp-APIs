using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        
     public UsersController(DataContext context)
     {
            _context = context;
        
     }   

     [HttpGet]
     public async Task<ActionResult<IEnumerable<AppUser>>> getUsers()
     {
        try
        {
            return Ok(await _context.Users.ToListAsync());
        }
        catch(Exception ex)
        {
            return BadRequest($"Something went wrong getting users\n" + ex.Message);
        }
     }

     [HttpGet("{id}")]
     public async Task<ActionResult<AppUser>> getUser(int id)
     {
        try
        {
            return await _context.Users.FindAsync(id);
        }
        catch (Exception ex)
        {
            return BadRequest($"Something went wrong getting user with id {id}\n" + ex.Message);
        }
     }
    }
}