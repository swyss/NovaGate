using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NovaGateFrontend.Pages.Account;

public class Login : PageModel
{
    [BindProperty]
    public required Credentials LoginCredentials { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Authentifizierungslogik hier einfügen
        // Wenn erfolgreich, Benutzer weiterleiten, sonst Fehlermeldung anzeigen

        return RedirectToPage("/Index");
    }
}

public class Credentials
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}