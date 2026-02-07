using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment1;

[ApiController]
[Route("api/[controller]")]
public class CountriesController : ControllerBase
{
    private readonly AppDbContext _context;

    public CountriesController(AppDbContext context)
    {
        _context = context;
    }    

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Country>>> GetCountries()
    {
        return await _context.Countries.ToListAsync();
    }
    
    [HttpGet]
    public async Task<ActionResult<Country>> GetCountry(int id)
    {
        var country = await _context.Countries.FindAsync(id);

        if(country == null)
        {
            return NotFound();
        }

        return country;
    }

    [HttpPost]
    public async Task<ActionResult<Country>> CreateCountry(Country country)
    {
        _context.Countries.Add(country);
        await _context.SaveChangesAsync();

        return country;
    }

    [HttpDelete("id")]
    public async Task<IActionResult> DeleteCountry(int Id)
    {
        var country = await _context.Countries.FindAsync(Id);
        if(country == null)
        {
            return NotFound();
        }

        _context.Countries.Remove(country);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> PutCountry(int id, Country country)
    {
        if(id != country.Id)
        {
            return BadRequest();
        }

        _context.Entry(country).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            return NotFound();
        }

        return Ok();
    }
}