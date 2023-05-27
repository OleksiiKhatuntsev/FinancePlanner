using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("/api/operationTypes")]
    public class OperationTypesController : BaseApiController
    {
        public OperationTypesController(DataContext context) : base(context) { }

        [HttpGet]
        public async Task<ActionResult<List<OperationType>>> GetOperationTypes() => await Context.OperationTypes.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<OperationType>> GetOperationType(Guid id) => await Context.OperationTypes.FindAsync(id);

    }
}