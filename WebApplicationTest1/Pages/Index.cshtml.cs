using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Simple.Encryption;

namespace WebApplicationTest1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IEncryption _encryption;

        [BindProperty]
        public string? EncryptedValue { get; set; } = string.Empty;
        [BindProperty]
        public string? PlainValue { get; set; } = "";

        public IndexModel(ILogger<IndexModel> logger, IEncryption encryption)
        {
            _logger = logger;
            _encryption = encryption;
        }


        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync()
        {
            EncryptedValue = "Vul een waarde in";
            if (!ModelState.IsValid || string.IsNullOrEmpty(PlainValue))
            {

            }
            else
            {
                EncryptedValue = _encryption?.Encrypt(PlainValue);
            }
            return Page();
        }
    }
}