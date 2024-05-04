using System.ComponentModel.DataAnnotations;

namespace CustomIdentity.ViewModels
{
	public class RegisterVM
	{
		[Required]
		public string? Name { get; set; }
		[Required]
		[DataType(DataType.EmailAddress)]
		public string? Email { get; set; }
		[Required]
		[DataType (DataType.Password)]
		public string? Password { get; set; }
		[Compare("Password",ErrorMessage ="Password mismatched")]
		[DataType(DataType.Password)]
		public string? ConfirmPassword {  get; set; }
		[DataType(DataType.MultilineText)]
		public string? Address {  get; set; }	
	}
}
