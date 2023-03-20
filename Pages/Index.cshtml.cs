using FizzBuzzWeb.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public FizzBuzzForm FizzBuzz { set; get; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public string Alert;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (FizzBuzz.Number % 15 == 0)
            {
                Alert = "FizzBuzz";
            }
            else if (FizzBuzz.Number % 3 == 0)
            {
                Alert = "Fizz";
            }
            else if (FizzBuzz.Number % 5 == 0)
            {
                Alert = "Buzz";
            }
            else
            {
                Alert = "Liczba " + FizzBuzz.Number + " nie spełnia kryteriów FizzBuzz";
            }

            return Page();
        }

    }
}