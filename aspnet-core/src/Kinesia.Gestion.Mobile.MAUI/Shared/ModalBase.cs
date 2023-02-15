﻿using Kinesia.Gestion.Core.Dependency;
using Kinesia.Gestion.Mobile.MAUI.Services.UI;

namespace Kinesia.Gestion.Mobile.MAUI.Shared
{
    public abstract class ModalBase : GestionComponentBase
    {
        protected ModalManagerService ModalManager { get; set; }

        public abstract string ModalId { get; }

        public ModalBase()
        {
            ModalManager = DependencyResolver.Resolve<ModalManagerService>();
        }

        public virtual async Task Show()
        {
            await ModalManager.Show(JS, ModalId);
            StateHasChanged();
        }

        public virtual async Task Hide()
        {
            await ModalManager.Hide(JS, ModalId);
        }
    }
}
