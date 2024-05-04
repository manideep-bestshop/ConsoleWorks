using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomIdentity.ViewModels
{
	public class LoginVM
	{
		[Required(ErrorMessage ="UserName is required")]
        public string? UserName { get; set; }
		[Required(ErrorMessage ="Password is required")]
		[DataType(DataType.Password)]
		public string? Password { get; set; }
		[DisplayName("Remember Me")]
		public bool RememberMe { get; set; }
    }
}
