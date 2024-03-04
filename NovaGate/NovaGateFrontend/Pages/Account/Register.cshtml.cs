using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NovaGateFrontend.Pages.Account;

public class Register : PageModel
{
    [BindProperty]
    public required NewUser RegistrationInfo { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Registrierungslogik hier einfügen
        // Wenn erfolgreich, Benutzer weiterleiten, sonst Fehlermeldung anzeigen

        return RedirectToPage("/Index");
    }
}

public class NewUser
{
    public required string Username { get; set; }
    public string? Email { get; set; }
    public required string Password { get; set; }
}