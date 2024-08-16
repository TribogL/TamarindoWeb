using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TamarindoWeb.Pages
{
    public class BuyWeapons : PageModel
    {
        private readonly ILogger<BuyWeapons> _logger;

        public BuyWeapons(ILogger<BuyWeapons> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}