using MediatR;
using Microsoft.AspNetCore.Mvc;
using Recycler.API.Queries.GetLogs;

namespace Recycler.API;

[ApiController]
[Route("[controller]")]
public class LogController(IMediator mediator, IGenericRepository<Order> orderRepository) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Log>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetLogs([FromQuery] GetLogsQuery query)
    {
        return Ok(await mediator.Send(query));
    }
}