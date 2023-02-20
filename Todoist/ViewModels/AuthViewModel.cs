using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Todoist.ViewModels
{
	public class AuthViewModel : IQueryAttributable, INotifyPropertyChanged
    { 
		public AuthViewModel()
		{
		}

        public event PropertyChangedEventHandler PropertyChanged;

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            throw new NotImplementedException();
        }

        [EmailAddress(ErrorMessage = "Not valid email address")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$", ErrorMessage = "Invalid email.")]
        [Required(ErrorMessage = "Required")]
        public string Email { get; set; }

        [StringLength(64, MinimumLength = 8,
            ErrorMessage = "The password should contain at least 8 characters.")]
        [Required(ErrorMessage = "Required")]
        public string Password { get; set; }

        public async void signUp(string email, string password)
        {
            // the function must call in the background and wait for a result
            // After getting the result invoke PropertyChanged
            await Shell.Current.GoToAsync("");
        }

    }
}

