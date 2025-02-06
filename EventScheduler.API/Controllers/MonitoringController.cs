using Microsoft.AspNetCore.Mvc;

namespace EventScheduler.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonitoringController : ControllerBase
    {

        #region Private Fields

        private readonly ILogger<MonitoringController> _logger;

        #endregion

        #region Constructor

        public MonitoringController(ILogger<MonitoringController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        #endregion

        #region Public Action Methods



        #endregion

    }
}
