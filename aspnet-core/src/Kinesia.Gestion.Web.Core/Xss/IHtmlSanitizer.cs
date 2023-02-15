using Abp.Dependency;

namespace Kinesia.Gestion.Web.Xss
{
    public interface IHtmlSanitizer: ITransientDependency
    {
        string Sanitize(string html);
    }
}