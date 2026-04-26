namespace simulacro.Models;

public class Treatment
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public int ConsultationId { get; set; }
    public Consultation? Consultation { get; set; }
}