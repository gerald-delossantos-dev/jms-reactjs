using DvmVircon.Jms.Api.Models;

namespace DvmVircon.Jms.Api.Services;

public sealed class DashboardDataService
{
    public DashboardResponse GetDashboard() => new(
        CompanyName: "DVM Vircon",
        CurrentUser: "John Dela Cruz",
        Role: "BIM Engineer",
        Metrics: new[]
        {
            new MetricCard("My Timesheet", "38.50 / 40", "This week", "96.25% submitted", "groups", "blue"),
            new MetricCard("My Tasks", "12", "In Progress", "3 due today", "task_alt", "orange"),
            new MetricCard("Active Projects", "8", "Assigned projects", "2 high priority", "folder", "blue"),
            new MetricCard("My KPI (MTD)", "92.4%", "Performance", "+4.3% vs Apr", "track_changes", "red"),
            new MetricCard("QA Reviews", "6", "Pending", "2 overdue", "star", "yellow"),
            new MetricCard("Billable Hours", "126.75h", "This month", "+12% vs Apr", "schedule", "green")
        },
        ProjectStatuses: new[]
        {
            new ProjectStatus("Active", 5, 63, "green"),
            new ProjectStatus("Planning", 1, 13, "blue"),
            new ProjectStatus("On Hold", 1, 13, "red"),
            new ProjectStatus("Completed", 1, 13, "slate")
        },
        TimesheetTrend: new[]
        {
            new TimesheetPoint("Mon", 7.5m), new TimesheetPoint("Tue", 8m), new TimesheetPoint("Wed", 8.5m),
            new TimesheetPoint("Thu", 7m), new TimesheetPoint("Fri", 7.5m), new TimesheetPoint("Sat", 0m), new TimesheetPoint("Sun", 0m)
        },
        TaskStatuses: new[]
        {
            new TaskStatus("Not Started", 8, 26, "slate"),
            new TaskStatus("In Progress", 12, 39, "blue"),
            new TaskStatus("On Review", 6, 19, "orange"),
            new TaskStatus("Completed", 5, 16, "green")
        },
        Deadlines: new[]
        {
            new DeadlineItem("BIM Coordination - Tower A", "LOD 400 Model", "Today", "May 20", "red"),
            new DeadlineItem("Shop Drawing Review", "Ducting Layout", "May 22", "2 days left", "orange"),
            new DeadlineItem("Clash Report - Level 15", "Architecture vs MEP", "May 24", "4 days left", "green"),
            new DeadlineItem("QA Check - Structural", "Pile Cap Details", "May 27", "7 days left", "blue")
        },
        RecentTasks: new[]
        {
            new RecentTask("Create Revit Model - Level 20", "Oxford Tower", "High", "May 20", "In Progress"),
            new RecentTask("Clash Detection - MEP vs Arch", "Metro Station", "Medium", "May 21", "In Progress"),
            new RecentTask("Update Sheet Layouts", "Hotel Project", "Low", "May 23", "Not Started"),
            new RecentTask("Coordinate Structural Model", "Data Center", "High", "May 24", "On Review"),
            new RecentTask("Quantity Takeoff - Concrete", "Mixed Use Bldg.", "Medium", "May 27", "Not Started")
        },
        Kpis: new[]
        {
            new KpiSummary("Productivity", "92.4%", "+4.3%", 92, "green"),
            new KpiSummary("Quality Score", "88.7%", "+2.1%", 89, "purple"),
            new KpiSummary("Timeliness", "90.1%", "+1.6%", 90, "blue"),
            new KpiSummary("Utilization", "81.6%", "-0.8%", 82, "orange")
        },
        Activities: new[]
        {
            new ActivityItem("Maria Santos", "submitted timesheet for the week.", "10 min ago", "MS"),
            new ActivityItem("Brian Lee", "completed task Clash Report - Level 12.", "1 hour ago", "BL"),
            new ActivityItem("James Tan", "uploaded QA/QC report.", "2 hours ago", "JT"),
            new ActivityItem("Angela Reyes", "updated the project schedule.", "3 hours ago", "AR")
        },
        QuickActions: new[]
        {
            new QuickAction("Log Timesheet", "Record work hours", "schedule"),
            new QuickAction("My Tasks", "View and manage tasks", "check_circle"),
            new QuickAction("Add Daily Log", "Submit work notes", "notes"),
            new QuickAction("Upload Document", "Attach project files", "upload_file"),
            new QuickAction("View Calendar", "Check deadlines", "calendar_month"),
            new QuickAction("SSRS Reports", "Generate reports", "bar_chart")
        }
    );
}
