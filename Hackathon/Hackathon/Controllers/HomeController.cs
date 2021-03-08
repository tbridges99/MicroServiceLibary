using Hackathon.Models;
using Hackathon.ServiceClients;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHackathonServiceClient _serviceClient;
        public HomeController(IHackathonServiceClient serviceClient)
        {
            _serviceClient = serviceClient;
        }

        public async Task<IActionResult> Index()
        {
            var services = await _serviceClient.GetServicesAsync("");
            return View(services);
        }
        public IActionResult Add()
        {
            return View(new ServiceDTO());
        }
        public async Task<IActionResult> Detail(int id)
        {
            var serviceInfo = await _serviceClient.GetServiceDetailsAsync(id);
            return View(new ServiceDTO { Name= "Covid Tracker API Service" });
        }
        public IActionResult JWT()
        {
            return View();
        }
    }
}
