using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
    public class BaseApiController : ControllerBase
    {
        protected readonly DataContext Context;

        public BaseApiController(DataContext context)
        {
            Context = context;
        }
    }
}