using APIRest.Interfaces;
using APIRest.Models;
using APIRest.Requests;
using Microsoft.AspNetCore.Mvc;

namespace APIRest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutoController : ControllerBase
    {
        private readonly IAutoService autoService;

        public AutoController(IAutoService autoService)
        {
            this.autoService = autoService;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Auto), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get([FromRoute] int id) 
        { 
            return Ok(await autoService.GetAutoAsync(id));
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Auto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await autoService.GetAutosAsync());
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Auto), StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return Ok(await autoService.DeleteAutoAsync(id));
        }


        [HttpPut("{id}")]
        [ProducesResponseType(typeof(Auto), StatusCodes.Status200OK)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] AutoRequest request)
        {
            return Ok(await autoService.UpdateAutoAsync(request, id));
        }


        [HttpPost]
        [ProducesResponseType(typeof(Auto), StatusCodes.Status200OK)]
        public async Task<IActionResult> Add([FromBody] AutoRequest request)
        {
            return Ok(await autoService.AddAutoAsync(request));
        }
    }
}