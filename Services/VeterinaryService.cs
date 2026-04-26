using Microsoft.EntityFrameworkCore;
using simulacro.Data;
using simulacro.Models;

namespace simulacro.Services;

public class VeterinaryService
{
    private readonly MySqlDbContext _context;

    public VeterinaryService(MySqlDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Veterinary>> GetAll()
    {
        var vets = await _context.veterinaries.ToListAsync();
        return vets;
    }

}