namespace DvmVircon.Jms.Api.Models;

public sealed record MetricCard(string Title, string Value, string Subtext, string Trend, string Icon, string Tone);
public sealed record ProjectStatus(string Name, int Count, int Percent, string Tone);
public sealed record TimesheetPoint(string Day, decimal Hours);
public sealed record TaskStatus(string Name, int Count, int Percent, string Tone);
public sealed record DeadlineItem(string Title, string Project, string DateLabel, string DueText, string Tone);
public sealed record RecentTask(string Task, string Project, string Priority, string DueDate, string Status);
public sealed record KpiSummary(string Name, string Value, string Trend, int Score, string Tone);
public sealed record ActivityItem(string Person, string Action, string Time, string Avatar);
public sealed record QuickAction(string Label, string Description, string Icon);

public sealed record DashboardResponse(
    string CompanyName,
    string CurrentUser,
    string Role,
    IReadOnlyList<MetricCard> Metrics,
    IReadOnlyList<ProjectStatus> ProjectStatuses,
    IReadOnlyList<TimesheetPoint> TimesheetTrend,
    IReadOnlyList<TaskStatus> TaskStatuses,
    IReadOnlyList<DeadlineItem> Deadlines,
    IReadOnlyList<RecentTask> RecentTasks,
    IReadOnlyList<KpiSummary> Kpis,
    IReadOnlyList<ActivityItem> Activities,
    IReadOnlyList<QuickAction> QuickActions);
