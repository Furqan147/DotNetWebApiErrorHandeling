using Microsoft.AspNetCore.Mvc;

namespace EventScheduler.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        #region Private Fields

        private readonly ILogger<AuthenticationController> _logger;

        #endregion

        #region Constructor

        public AuthenticationController(ILogger<AuthenticationController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        #endregion

        #region Public Action Methods



        #endregion

    }
}
