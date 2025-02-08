using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.Entities;

public class Employee : BaseEntity
{
    [Required] public string? CivilId { get; set; }
    [Required] public string? FileNumber { get; set; }
    [Required] public string? FullName { get; set; }
    [Required] public string? JobName { get; set; }
    [Required] public string? Address { get; set; }

    [Required] public string? TelephoneNumber { get; set; }
    [Required] public string? Photo { get; set; }
    [Required] public string? Other { get; set; }

    //Many to one relationship
    public Branch? Branch { get; set; }
    public int BranchId { get; set; }

    public Town? Town { get; set; }
    public int TownId { get; set; }
}