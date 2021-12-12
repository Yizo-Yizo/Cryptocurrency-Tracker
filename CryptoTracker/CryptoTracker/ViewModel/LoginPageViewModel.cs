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
    public class LoginPageViewModel : ViewModelBase
    {
        private readonly IUserDataService _userDataService;
        private AppUser _user;
        public LoginPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            CurrentUser = new AppUser();
        }

        public AppUser CurrentUser
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }

        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand));

        public async void ExecuteLoginCommand()
        {
            //await _userDataService.AddUser(CurrentUser);
            /*LoginService service = new LoginService();
            var getLoginDetails = await service.CheckLoginifExists(CurrentUser.Email, CurrentUser.Password);

            if (getLoginDetails)
            {
                await PageDialogService.DisplayAlertAsync("Login Successful", "Username and Password are correct", "Okay", "Cancel");
            }
            else if (CurrentUser.Email == null || CurrentUser.Password == null)
            {
                await PageDialogService.DisplayAlertAsync("Login failed", "Enter all fields", "Okay", "Cancel");
            }
            else
            {
                await PageDialogService.DisplayAlertAsync("Login failed", "Username or Password is incorrect", "Okay", "Cancel");
            }

            await NavigationService.NavigateAsync("CryptoPriceLIst");*/
        }

        private DelegateCommand _registerCommand;

        public DelegateCommand RegisterCommand =>
            _registerCommand ?? (_registerCommand = new DelegateCommand(ExecuteRegisterCommand));

        async void ExecuteRegisterCommand()
        {
            await NavigationService.NavigateAsync("SignUpPage");
        }
    }
}
