namespace simulacro.Models;

public class TreatmentMedicine
{
    public int Id { get; set; }
    public int TreatmentId { get; set; }
    public Treatment? Treatment { get; set; }  
    public int MedicineId { get; set; }
    public Medicine? Medicine { get; set; }
    public IEnumerable<Medicine>? Medicines { get; set; }
    
}