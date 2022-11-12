using System.ComponentModel.DataAnnotations;

namespace GameSite.Models.Account;

public class Login {

	[Required]
	[EmailAddress]
	public string Email { get; set; }

	[Required]
	[DataType(DataType.Password)]
	public string Password { get; set; }

}