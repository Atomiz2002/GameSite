using System.ComponentModel.DataAnnotations;

namespace GameSite.Models.Identity;

public class Register {

	public string Pfp { get; set; }

	[Required]
	[StringLength(20, MinimumLength = 5)]
	public string Username { get; set; }

	[Required]
	[DataType(DataType.EmailAddress)]
	[StringLength(60, MinimumLength = 5)]
	public string Email { get; set; }

	[Required]
	[DataType(DataType.Password)]
	public string Password { get; set; }

	[Required]
	[Compare(nameof(Password))]
	public string PasswordConfirm { get; set; }

}