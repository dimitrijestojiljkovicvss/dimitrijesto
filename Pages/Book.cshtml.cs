using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Projekt.Pages
{
    public class BookModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Details { get; set; }

        public void OnPost()
        {
            // TODO: Save to DB or send email
        }
    }
}
