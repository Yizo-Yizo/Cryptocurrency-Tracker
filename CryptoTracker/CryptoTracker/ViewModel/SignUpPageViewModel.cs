using CryptoTracker.Interfaces;
using CryptoTracker.Models;
using CryptoTracker.ServiceHandler;
using CryptoTracker.Services;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoTracker.ViewModel
{
    public class SignUpPageViewModel : ViewModelBase
    {
        private IUserDataService _userDataService;
        //private Users _user;

        //ApiServices service = new ApiServices();
        public SignUpPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IUserDataService userDataService) : base(navigationService, pageDialogService)
        {
            _userDataService = userDataService;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; } 
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        private DelegateCommand _signUpCommand;

        public DelegateCommand SignUpCommand =>
            _signUpCommand ?? (_signUpCommand = new DelegateCommand((ExecuteSignUpCommand)));
        public async void ExecuteSignUpCommand()
        {
            //await _userDataService.AddUser(CurrentUser);

            var getLoginDetails = await _userDataService.Register(Name, Surname, Email, ContactNumber, Password, ConfirmPassword);

            if (getLoginDetails)
            {
                await PageDialogService.DisplayAlertAsync("Registration Successful", "Your registration has been successful", "Okay", "Cancel");
                await NavigationService.NavigateAsync("LoginPage");
            }
            else
            {
                await PageDialogService.DisplayAlertAsync("Registration unsuccessful", "Your registration was unsuccessful", "Okay", "Cancel"); 
                await NavigationService.NavigateAsync("LoginPage");
            }
                
        }
    }
}
