using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GameSite.Models.Account;

public class Register {

	public string Pfp { get; set; }

	[Required]
	public string Username { get; set; }

	[Required]
	[EmailAddress]
	public string Email { get; set; }

	[Required]
	[DataType(DataType.Password)]
	public string Password { get; set; }

	[Required]
	[Compare(nameof(Password))]
	public string PasswordConfirm { get; set; }

}