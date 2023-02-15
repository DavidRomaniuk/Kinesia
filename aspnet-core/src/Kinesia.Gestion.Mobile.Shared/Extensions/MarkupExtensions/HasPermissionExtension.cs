using System;
using Kinesia.Gestion.Core;
using Kinesia.Gestion.Core.Dependency;
using Kinesia.Gestion.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Kinesia.Gestion.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}