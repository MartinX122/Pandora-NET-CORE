using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pandora_NET_CORE.Models;

namespace Pandora_NET_CORE.Controllers
{
    public class PagesController : Controller
    {
        private readonly ILogger<PagesController> _logger;

        public PagesController(ILogger<PagesController> logger)
        {
            _logger = logger;
        }

        public IActionResult _404() => View();
        public IActionResult _500() => View();
        public IActionResult audio() => View();
        public IActionResult buttons() => View();
        public IActionResult calendar() => View();
        public IActionResult chat() => View();
        public IActionResult colors() => View();
        public IActionResult coming_soon() => View();
        public IActionResult compose() => View();
        public IActionResult countdown() => View();
        public IActionResult dashboard() => View();
        public IActionResult dialogs() => View();
        public IActionResult forms_basic() => View();
        public IActionResult forms_extended() => View();
        public IActionResult forms_layouts() => View();
        public IActionResult forms_validating() => View();
        public IActionResult help_center() => View();
        public IActionResult hints() => View();
        public IActionResult inbox() => View();
        public IActionResult inbox2() => View();
        public IActionResult info_boxes() => View();
        public IActionResult invoice() => View();
        public IActionResult list() => View();
        public IActionResult listview() => View();
        public IActionResult lockscreen() => View();
        public IActionResult login() => View();
        public IActionResult maintenance() => View();
        public IActionResult master() => View();
        public IActionResult notifies() => View();
        public IActionResult order_details() => View();
        public IActionResult orders() => View();
        public IActionResult preloader() => View();
        public IActionResult price_table() => View();
        public IActionResult product_list() => View();
        public IActionResult product() => View();
        public IActionResult profile() => View();
        public IActionResult progress() => View();
        public IActionResult read_email() => View();
        public IActionResult register() => View();
        public IActionResult splitter() => View();
        public IActionResult table_classes() => View();
        public IActionResult table_component() => View();
        public IActionResult tabs() => View();
        public IActionResult tiles() => View();
        public IActionResult toasts() => View();
        public IActionResult treeview() => View();
        public IActionResult typography() => View();
        public IActionResult video() => View();
        public IActionResult widgets() => View();
        public IActionResult windows() => View();
        public IActionResult wizard() => View();



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
