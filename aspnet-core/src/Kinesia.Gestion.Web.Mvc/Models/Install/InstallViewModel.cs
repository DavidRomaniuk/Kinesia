using System.Collections.Generic;
using Abp.Localization;
using Kinesia.Gestion.Install.Dto;

namespace Kinesia.Gestion.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
