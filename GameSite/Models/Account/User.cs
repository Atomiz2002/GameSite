using Microsoft.AspNetCore.Identity;

namespace GameSite.Models.Account;

public class User : IdentityUser {

	private string Pfp { get; }

}