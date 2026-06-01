namespace EventEase_Copilot_Blazor.Models;

public class AttendanceRecord
{
    public int EventId { get; set; }

    public string EventName { get; set; } = string.Empty;

    public string AttendeeName { get; set; } = string.Empty;

    public string AttendeeEmail { get; set; } = string.Empty;

    public DateTime RegistrationDate { get; set; } = DateTime.Now;
}
