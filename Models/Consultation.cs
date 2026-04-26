namespace simulacro.Models;

public class Consultation
{
    public int Id { get; set; }
    public string Reason { get; set; } = string.Empty;
    public int VeterinaryId { get; set; }
    public Veterinary? Veterinary { get; set; }
    public int PetId { get; set; }
    public Pet? Pet { get; set; }
    
    public DateTime Date { get; set; } = DateTime.UtcNow;
}