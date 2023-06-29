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

        public JellybenchApiController(IJellybenchManagerService jellybenchManagerService)
        {
            _jellybenchManagerService = jellybenchManagerService;
        }

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

        [HttpGet]
        [Route("StartReportGeneration")]
        public IActionResult StartReportGeneration()
        {
            _jellybenchManagerService.RunReport();
            return Ok();
        }
    }
}
