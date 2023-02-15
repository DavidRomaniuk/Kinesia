using System.Threading.Tasks;
using Kinesia.Gestion.Security.Recaptcha;

namespace Kinesia.Gestion.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
