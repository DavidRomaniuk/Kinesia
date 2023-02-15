using System.Collections.Generic;
using Kinesia.Gestion.Editions.Dto;

namespace Kinesia.Gestion.Web.Areas.App.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}