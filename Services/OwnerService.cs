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

    public IEnumerable<Owner> GetAll()
    {
        var owners = _context.owners.ToList();
        return owners;
    }
}