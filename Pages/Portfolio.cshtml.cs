using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Linq;

namespace Projekt.Pages
{
    public class PortfolioModel : PageModel
    {
        public List<string> Images { get; set; } = new();

        public void OnGet()
        {
            // Absolute path to the folder
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "portfolio");

            if (Directory.Exists(folderPath))
            {
                Images = Directory.GetFiles(folderPath)
                    .Select(file => "/images/portfolio/" + Path.GetFileName(file))
                    .ToList();
            }
        }
    }
}
