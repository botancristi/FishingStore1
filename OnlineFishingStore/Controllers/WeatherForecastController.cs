using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineFishingStore.Models;

namespace OnlineFishingStore.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        FishingStoreContext db;
        public HomeController(FishingStoreContext context)
        {
            db = context;
        }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

    }
}
