using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Voltron.Hackathon.Models;
using Voltron.Hackathon.Repositories;

namespace Voltron.Hackathon.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("ServiceDirectory")]
    public class ServiceDirectory : Controller
    {
        private readonly IServiceRepository _repo;

        public ServiceDirectory(IServiceRepository repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("Get")]
        public async Task<IActionResult> Index()
        {
            var services = await _repo.GetServicesAsync("");
            return Ok(services);
        }
    }
}
