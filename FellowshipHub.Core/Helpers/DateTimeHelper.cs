namespace FellowshipHub.Core.Helpers;

public static class DateTimeHelper
{
    public static string ToRelativeTime(this DateTime dateTime)
    {
        var timeSpan = DateTime.UtcNow - dateTime.ToUniversalTime();

        return timeSpan switch
        {
            { TotalMinutes: < 1 } => "Just now",
            { TotalMinutes: < 60 } => $"{(int)timeSpan.TotalMinutes}m ago",
            { TotalHours: < 24 } => $"{(int)timeSpan.TotalHours}h ago",
            { TotalDays: < 7 } => $"{(int)timeSpan.TotalDays}d ago",
            { TotalDays: < 30 } => $"{(int)(timeSpan.TotalDays / 7)}w ago",
            _ => dateTime.ToString("MMM dd, yyyy")
        };
    }

    public static string ToFriendlyTime(this DateTime dateTime)
    {
        var today = DateTime.Today;
        var date = dateTime.Date;

        if (date == today)
            return $"Today at {dateTime:h:mm tt}";

        if (date == today.AddDays(-1))
            return $"Yesterday at {dateTime:h:mm tt}";

        return date > today.AddDays(-7) ? $"{dateTime:dddd} at {dateTime:h:mm tt}" : dateTime.ToString("MMM dd, yyyy 'at' h:mm tt");
    }

    public static bool IsToday(this DateTime dateTime)
    {
        return dateTime.Date == DateTime.Today;
    }

    public static bool IsThisWeek(this DateTime dateTime)
    {
        var startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
        return dateTime.Date >= startOfWeek;
    }
}