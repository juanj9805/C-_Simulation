using Microsoft.EntityFrameworkCore;
using simulacro.Data;
using simulacro.Models;

namespace simulacro.Services;

public class MedicineService
{
    private readonly MySqlDbContext _context;

    public MedicineService(MySqlDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Medicine>> GetAll()
    {
        var medi = await _context.medicines.ToListAsync();
        return medi;
    }
    
    public async Task<Medicine> Create(Medicine medicine)
    {
        if (medicine != null)
        {
            _context.Add(medicine);
            await _context.SaveChangesAsync();
        }

        return null;
    }
}