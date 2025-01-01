using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesPractice.Pages
{
    public class Index1Model : PageModel
    {
        public List<string> Hobbies { get; set; }

        public void OnGet()
        {
            
            Hobbies = new List<string>
        {
            "Reading", "Traveling", "Cooking", "Sports", "Music", "Photography"
        };

            ViewData["Title"] = "Dynamic Survey Page"; 
        }

        public void OnPost()
        {
            
        }
    }
}

