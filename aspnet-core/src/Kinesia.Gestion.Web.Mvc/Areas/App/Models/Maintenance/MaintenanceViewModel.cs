using System.Collections.Generic;
using Kinesia.Gestion.Caching.Dto;

namespace Kinesia.Gestion.Web.Areas.App.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}