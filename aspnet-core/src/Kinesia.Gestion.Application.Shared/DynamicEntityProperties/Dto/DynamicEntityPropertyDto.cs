﻿using Abp.Application.Services.Dto;

namespace Kinesia.Gestion.DynamicEntityProperties.Dto
{
    public class DynamicEntityPropertyDto : EntityDto
    {
        public string EntityFullName { get; set; }

        public string DynamicPropertyName { get; set; }

        public int DynamicPropertyId { get; set; }

        public int? TenantId { get; set; }
    }
}