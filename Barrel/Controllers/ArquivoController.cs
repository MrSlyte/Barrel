using Barrel.Application.Arquivo.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Barrel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArquivoController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetCreateArquivoQuery());
            return Ok(result);
        }
    }
}