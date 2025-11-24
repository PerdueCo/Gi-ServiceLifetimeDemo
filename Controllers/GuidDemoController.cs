

using Microsoft.AspNetCore.Mvc;
using ServiceLifetimeDemo.Services;

namespace ServiceLifetimeDemo.Controllers;

// This controller exposes an endpoint to return the GUIDs
// from all 3 service lifetimes.
[ApiController]
[Route("api/[controller]")]
public class GuidDemoController : ControllerBase
{
    private readonly TransientGuidService _transient;
    private readonly ScopedGuidService _scoped;
    private readonly SingletonGuidService _singleton;

    // ASP.NET Core will automatically inject the right services here.
    public GuidDemoController(
        TransientGuidService transient,
        ScopedGuidService scoped,
        SingletonGuidService singleton)
    {
        _transient = transient;
        _scoped = scoped;
        _singleton = singleton;
    }

    // GET /api/GuidDemo
    [HttpGet]
    public IActionResult Get()
    {
        // Return the GUID values so the UI can display them
        return Ok(new
        {
            transient = _transient.Guid,
            scoped = _scoped.Guid,
            singleton = _singleton.Guid
        });
    }
}


