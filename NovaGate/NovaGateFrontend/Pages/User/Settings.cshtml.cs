using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NovaGateFrontend.Pages.User;

public class Settings : PageModel
{
    [BindProperty]
    public UserSettings UserSettings { get; set; }

    public void OnGet()
    {
        // Hier die Logik einfügen, um die Einstellungen des Benutzers zu laden
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Hier die Logik einfügen, um die aktualisierten Einstellungen zu speichern

        return RedirectToPage();
    }
}

public class UserSettings
{
    // Beispiel für eine Einstellung
    public bool EnableNotifications { get; set; }
    // Weitere Einstellungen nach Bedarf
}