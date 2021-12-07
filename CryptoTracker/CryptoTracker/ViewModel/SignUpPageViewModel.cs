using CryptoTracker.Interfaces;
using CryptoTracker.Models;
using CryptoTracker.ServiceHandler;
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
        private Users _user;
        public SignUpPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IUserDataService userDataService) : base(navigationService, pageDialogService)
        {
            _userDataService = userDataService;
        }

        public Users CurrentUser
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }

        private DelegateCommand _signUpCommand;

        public DelegateCommand SignUpCommand =>
            _signUpCommand ?? (_signUpCommand = new DelegateCommand((ExecuteSignUpCommand)));
        public async void ExecuteSignUpCommand()
        {
            await _userDataService.AddUser(CurrentUser);
            LoginService service = new LoginService();
            var getLoginDetails = await service.CheckLoginifExists(CurrentUser.Email, CurrentUser.Password);

            if (CurrentUser.Name == null || CurrentUser.Email == null || CurrentUser.ContactNumber == null || CurrentUser.Password == null)
            {
                await PageDialogService.DisplayAlertAsync("Registration failed", "Enter all feilds", "Okay", "Cancel");
            }
            else if (getLoginDetails)
            {
                await PageDialogService.DisplayAlertAsync("Registration failed", "Already have an account", "Okay", "Cancel");
            }
            else
            {
                await PageDialogService.DisplayAlertAsync("Registration successful", "Enjoy", "Okay", "Cancel");
                await NavigationService.NavigateAsync("LoginPage");
            }
        }
    }
}
