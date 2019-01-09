using DotNetTask.Api.Account;
using DotNetTask.Api.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTask.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ICommandHandler<CreateAccountCommand> _createAccountCommandHandler;

        public AccountController(ICommandHandler<CreateAccountCommand> createAccountCommandHandler)
        {
            _createAccountCommandHandler = createAccountCommandHandler;
        }

        [HttpPost]
        public void Post([FromBody] CreateAccountCommand command)
        {
            _createAccountCommandHandler.Handle(command);
        }
    }
}