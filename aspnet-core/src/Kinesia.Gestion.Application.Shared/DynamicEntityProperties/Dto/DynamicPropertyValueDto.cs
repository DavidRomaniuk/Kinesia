using Abp.Application.Services.Dto;

namespace Kinesia.Gestion.DynamicEntityProperties.Dto
{
    public class DynamicPropertyValueDto : EntityDto
    {
        public virtual string Value { get; set; }

        public int? TenantId { get; set; }

        public int DynamicPropertyId { get; set; }
    }
}
