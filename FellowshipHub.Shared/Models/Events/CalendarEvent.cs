using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FellowshipHub.Shared.Models.Events;

[Table("CalendarEvents")]
public class CalendarEvent : BaseEntity
{
    [JsonPropertyName("title")] public string Title { get; set; } = string.Empty;

    [JsonPropertyName("description")] public string? Description { get; set; }

    [JsonPropertyName("groupId")] public Guid GroupId { get; set; }

    [JsonPropertyName("startTime")] public DateTime StartTime { get; set; }

    [JsonPropertyName("endTime")] public DateTime? EndTime { get; set; }

    [JsonPropertyName("isAllDay")] public bool IsAllDay { get; set; } = false;

    [JsonPropertyName("location")] public string? Location { get; set; }

    [JsonPropertyName("recurrenceRule")] public string? RecurrenceRule { get; set; }
}