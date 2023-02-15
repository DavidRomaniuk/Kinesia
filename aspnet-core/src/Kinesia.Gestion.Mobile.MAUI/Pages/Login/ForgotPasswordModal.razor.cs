using Microsoft.AspNetCore.Components;
using Kinesia.Gestion.Authorization.Accounts;
using Kinesia.Gestion.Authorization.Accounts.Dto;
using Kinesia.Gestion.Core.Dependency;
using Kinesia.Gestion.Core.Threading;
using Kinesia.Gestion.Mobile.MAUI.Models.Login;
using Kinesia.Gestion.Mobile.MAUI.Shared;

namespace Kinesia.Gestion.Mobile.MAUI.Pages.Login
{
    public partial class ForgotPasswordModal : ModalBase
    {
        public override string ModalId => "forgot-password-modal";
       
        [Parameter] public EventCallback OnSave { get; set; }
        
        public ForgotPasswordModel forgotPasswordModel { get; set; } = new ForgotPasswordModel();

        private readonly IAccountAppService _accountAppService;

        public ForgotPasswordModal()
        {
            _accountAppService = DependencyResolver.Resolve<IAccountAppService>();
        }

        protected virtual async Task Save()
        {
            await SetBusyAsync(async () =>
            {
                await WebRequestExecuter.Execute(
                async () =>
                    await _accountAppService.SendPasswordResetCode(new SendPasswordResetCodeInput { EmailAddress = forgotPasswordModel.EmailAddress }),
                    async () =>
                    {
                        await OnSave.InvokeAsync();
                    }
                );
            });
        }

        protected virtual async Task Cancel()
        {
            await Hide();
        }
    }
}
