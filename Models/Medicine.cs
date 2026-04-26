namespace simulacro.Models;

public class Medicine
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int TreatmentId { get; set; }
    public Treatment? Treatment { get; set; }
}