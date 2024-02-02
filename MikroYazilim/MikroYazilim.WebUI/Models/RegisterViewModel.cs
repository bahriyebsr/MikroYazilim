using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MikroYazilim.WebUI.Models
{
	public class RegisterViewModel
	{


		[Display(Name = "Adı")]
		[MaxLength(25, ErrorMessage = "İsim maksimum 25 karakter uzunluğunda olabilir.")]
		[Required(ErrorMessage = "Ad Alanı boş bırakılamaz.")]
		public string FirstName { get; set; }
		[Display(Name = "Soyadı")]
		[MaxLength(25, ErrorMessage = "İsim maksimum 25 karakter uzunluğunda olabilir.")]
		[Required(ErrorMessage = "Soyad Alanı boş bırakılamaz.")]
		public string LastName { get; set; }
		[Display(Name = "Eposta")]
		[MaxLength(25, ErrorMessage = "İsim maksimum 25 karakter uzunluğunda olabilir.")]
		public string Email { get; set; }
		[Display(Name = "Şifre")]
		[MaxLength(25, ErrorMessage = "İsim maksimum 25 karakter uzunluğunda olabilir.")]
		public string Password { get; set; }
		[Display(Name = "Şifre tekrarı")]
		[MaxLength(25, ErrorMessage = "İsim maksimum 25 karakter uzunluğunda olabilir.")]
		[Compare(nameof(Password), ErrorMessage = "Şifreler eşleşmiyor.")]

		public string PasswordConfirm { get; set; }
	}
	}

