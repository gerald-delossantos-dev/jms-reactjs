using DvmVircon.Jms.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace DvmVircon.Jms.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class DashboardController(DashboardDataService dashboardDataService) : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(dashboardDataService.GetDashboard());
}
