using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HWRazorPages.Models;

namespace HWRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public AppMessage Heading { get; set; }
        public string SubHeading { get; set; }

        public void OnGet()
        {
            this.Heading = new AppMessage();
            this.Heading.Message = "Hello World Razor Pages";
        }
        public void OnPost()
        {
            this.SubHeading = "Message Changed";
        }
    }
}
