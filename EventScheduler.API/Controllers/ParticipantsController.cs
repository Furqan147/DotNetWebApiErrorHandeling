using Microsoft.AspNetCore.Mvc;

namespace EventScheduler.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantsController : ControllerBase
    {

        #region Private Fields

        private readonly ILogger<ParticipantsController> _logger;

        #endregion

        #region Constructor

        public ParticipantsController(ILogger<ParticipantsController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        #endregion

        #region Public Action Methods



        #endregion

    }
}
