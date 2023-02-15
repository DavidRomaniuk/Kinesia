using Kinesia.Gestion.Core.Dependency;
using Kinesia.Gestion.Mobile.MAUI.Shared;
using Kinesia.Gestion.Services.Account;
using Kinesia.Gestion.Services.Navigation;

namespace Kinesia.Gestion.Mobile.MAUI.Pages.MySettings
{
    public partial class Settings : GestionMainLayoutPageComponentBase
    {
        protected IAccountService AccountService { get; set; }
        protected NavMenu NavMenu { get; set; }

        protected INavigationService navigationService { get; set; }
        ChangePasswordModal changePasswordModal;

        public Settings()
        {
            AccountService = DependencyResolver.Resolve<IAccountService>();
            navigationService = DependencyResolver.Resolve<INavigationService>();
        }

        protected override async Task OnInitializedAsync()
        {
            await SetPageHeader(L("MySettings"));
        }

        private async Task LogOut()
        {
            await AccountService.LogoutAsync();
            navigationService.NavigateTo(NavigationUrlConsts.Login);
        }

        private async Task OnChangePasswordAsync()
        {
            await changePasswordModal.Hide();
            await Task.Delay(300);
            await LogOut();
        }

        private async Task OnLanguageSwitchAsync()
        {
            await SetPageHeader(L("MySettings"));
            StateHasChanged();
        }

        private async Task ChangePassword()
        {
            await changePasswordModal.Show();
        }

    }
}
