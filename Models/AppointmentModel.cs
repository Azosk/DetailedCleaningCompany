using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DetailedCleaningCompany.Models;

public class Appointment
{
    public int AppointmentId { get; set; }
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public string? Type { get; set; }
    [DataType(DataType.Date)]
    public DateTime DateTime { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Comments { get; set; }
}