using System.Threading.Tasks;

namespace Kinesia.Gestion.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}