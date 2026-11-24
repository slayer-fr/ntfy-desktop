namespace NtfyDesktop.Domain;

public enum Priority
{
    Min = 1,
    Low = 2,
    Default = 3,
    High = 4,
    Urgent = 5
}

public static class PriorityExtensions
{
    extension(Priority p)
    {
        public string Label => p switch
        {
            Priority.Min => Loc.T("Min"),
            Priority.Low => Loc.T("Low"),
            Priority.Default => Loc.T("Default"),
            Priority.High => Loc.T("High"),
            Priority.Urgent => Loc.T("Urgent"),
            _ => p.ToString()
        };
    }
}
