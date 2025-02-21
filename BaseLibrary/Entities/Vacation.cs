using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.Entities;

public class Vacation : BaseEntity
{
    [Required] public DateTime StartDate { get; set; }

    [Required] public int NumberOfDays { get; set; }
    public DateTime EndDate => StartDate.AddDays(NumberOfDays);

    public VacationType? VacationType { get; set; }
    public int VacationTypeId { get; set; }
}