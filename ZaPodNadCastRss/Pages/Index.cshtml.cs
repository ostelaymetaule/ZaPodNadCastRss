using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZaPodNadCastRss.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public String PageName { get; set; }
        public void OnGet()
        {
            PageName = "MyRssGenerator mainPage";
        }
    }
}