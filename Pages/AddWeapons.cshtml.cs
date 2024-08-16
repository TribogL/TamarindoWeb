using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace TamarindoWeb.Pages
{
    public class AddWeapons : PageModel
    {
        private readonly ILogger<AddWeapons> _logger;

        public AddWeapons(ILogger<AddWeapons> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}