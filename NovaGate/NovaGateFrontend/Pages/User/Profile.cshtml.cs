using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NovaGateFrontend.Pages.User;

public class Profile : PageModel
{
    [BindProperty]
    public UserProfile UserProfile { get; set; }

    public void OnGet()
    {
        // Hier würde die Logik stehen, um die Benutzerprofildaten zu laden,
        // z.B. aus der Datenbank oder einem anderen Speicher.
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Hier die Logik einfügen, um die aktualisierten Profildaten zu speichern

        return RedirectToPage();
    }
}

public class UserProfile
{
    public string Username { get; set; }
    public string Email { get; set; }
    // Weitere Profilfelder nach Bedarf
}