using Microsoft.AspNetCore.Components;
using Kinesia.Gestion.Authorization.Accounts;
using Kinesia.Gestion.Authorization.Accounts.Dto;
using Kinesia.Gestion.Core.Dependency;
using Kinesia.Gestion.Core.Threading;
using Kinesia.Gestion.Mobile.MAUI.Models.Login;
using Kinesia.Gestion.Mobile.MAUI.Shared;

namespace Kinesia.Gestion.Mobile.MAUI.Pages.Login
{
    public partial class EmailActivationModal : ModalBase
    {
        public override string ModalId => "email-activation-modal";

        [Parameter] public EventCallback OnSave { get; set; }

        public EmailActivationModel emailActivationModel { get; set; } = new EmailActivationModel();

        private readonly IAccountAppService _accountAppService;

        public EmailActivationModal()
        {
            _accountAppService = DependencyResolver.Resolve<IAccountAppService>();
        }

        protected virtual async Task Save()
        {
            await SetBusyAsync(async () =>
            {
                await WebRequestExecuter.Execute(
                async () =>
                    await _accountAppService.SendEmailActivationLink(new SendEmailActivationLinkInput
                    {
                        EmailAddress = emailActivationModel.EmailAddress
                    }),
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
