using Microsoft.EntityFrameworkCore;
using simulacro.Data;
using simulacro.Models;

namespace simulacro.Services;

public class OwnerService
{
    private readonly MySqlDbContext _context;

    public OwnerService(MySqlDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Owner>> GetAll()
    {
        var owners = await _context.owners.ToListAsync();
        return owners;
    }
}