using EventEase_Copilot_Blazor.Models;

namespace EventEase_Copilot_Blazor.Services;

public class AttendanceService
{
    private readonly List<AttendanceRecord> records = new();

    public void AddRecord(AttendanceRecord record)
    {
        records.Add(record);
    }

    public List<AttendanceRecord> GetRecords()
    {
        return records;
    }
}
