using Microsoft.AspNetCore.Mvc;

namespace EventScheduler.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {

        #region Private Fields

        private readonly ILogger<EventsController> _logger;

        #endregion

        #region Constructor

        public EventsController(ILogger<EventsController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        #endregion

        #region Public Action Methods



        #endregion

    }
}
