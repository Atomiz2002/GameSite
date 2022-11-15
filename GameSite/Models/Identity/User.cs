using Microsoft.AspNetCore.Identity;

namespace GameSite.Models.Identity;

public class User : IdentityUser {

	private string? Pfp { get; set; }

}