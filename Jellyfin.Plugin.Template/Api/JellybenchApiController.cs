using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jellyfin.Plugin.Template.Services.JellybenchManager;
using Microsoft.AspNetCore.Mvc;

namespace Jellyfin.Plugin.Template.Controller
{
    /// <summary>
    /// Controller for invoking Jellybech methods.
    /// </summary>
    [ApiController]
    [Route("/api/{ControllerName}")]
    public class JellybenchApiController : ControllerBase
    {
        private readonly IJellybenchManagerService _jellybenchManagerService;

        /// <summary>
        /// Initializes a new instance of the <see cref="JellybenchApiController"/> class.
        /// </summary>
        /// <param name="jellybenchManagerService">Jellyfin benchmark service.</param>
        public JellybenchApiController(IJellybenchManagerService jellybenchManagerService)
        {
            _jellybenchManagerService = jellybenchManagerService;
        }

        /// <summary>
        /// Get report.
        /// </summary>
        /// <returns>report.</returns>
        [HttpGet]
        [Route("GetReport")]
        public IActionResult GetReport()
        {
            if (_jellybenchManagerService.HasReport)
            {
                return Ok(_jellybenchManagerService.ReadReport());
            }

            return NoContent();
        }

        /// <summary>
        /// Start the report generation.
        /// </summary>
        /// <returns>ok.</returns>
        [HttpGet]
        [Route("StartReportGeneration")]
        public IActionResult StartReportGeneration()
        {
            _jellybenchManagerService.RunReport();
            return Ok();
        }
    }
}
