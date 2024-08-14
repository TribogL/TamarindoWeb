using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TamarindoWeb.Pages
{
    public class Weapons : PageModel
    {
        private readonly ILogger<Weapons> _logger;

        public Weapons(ILogger<Weapons> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}