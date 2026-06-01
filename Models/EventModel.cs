namespace EventEase_Copilot_Blazor.Models;

public class EventModel
{
    public int Id { get; set; }

    public string EventName { get; set; } = string.Empty;

    public DateTime EventDate { get; set; }

    public string Location { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
}
