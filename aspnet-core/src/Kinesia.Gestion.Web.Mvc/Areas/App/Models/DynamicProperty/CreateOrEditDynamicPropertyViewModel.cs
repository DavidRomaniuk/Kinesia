using System.Collections.Generic;
using Kinesia.Gestion.DynamicEntityProperties.Dto;

namespace Kinesia.Gestion.Web.Areas.App.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
