using EventEase_Copilot_Blazor.Models;

namespace EventEase_Copilot_Blazor.Services;

public class EventService
{
    private readonly List<EventModel> eventList = new();

    public EventService()
    {
        eventList.Add(new EventModel { Id = 1, EventName = "Corporate Summit", EventDate = DateTime.Today.AddDays(15), Location = "Tampa", Description = "Business event." });
        eventList.Add(new EventModel { Id = 2, EventName = "Technology Expo", EventDate = DateTime.Today.AddDays(30), Location = "Orlando", Description = "Technology event." });
        eventList.Add(new EventModel { Id = 3, EventName = "Community Event", EventDate = DateTime.Today.AddDays(45), Location = "St. Petersburg", Description = "Community event." });
    }

    public List<EventModel> GetEvents()
    {
        return eventList;
    }

    public EventModel? GetEventById(int id)
    {
        return eventList.FirstOrDefault(item => item.Id == id);
    }
}
