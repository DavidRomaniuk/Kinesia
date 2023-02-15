using Abp.Configuration;

namespace Kinesia.Gestion.Timing.Dto
{
    public class GetTimezonesInput
    {
        public SettingScopes DefaultTimezoneScope { get; set; }
    }
}
