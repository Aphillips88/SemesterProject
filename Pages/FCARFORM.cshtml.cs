using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace cidm4390.Pages
{
    public class FCARFORMModel : PageModel
    {
        private readonly ILogger<FCARFORMModel> _logger;

        public FCARFORMModel(ILogger<FCARFORMModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
