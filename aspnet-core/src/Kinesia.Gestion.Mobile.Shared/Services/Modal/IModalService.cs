using System.Threading.Tasks;
using Kinesia.Gestion.Views;
using Xamarin.Forms;

namespace Kinesia.Gestion.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
