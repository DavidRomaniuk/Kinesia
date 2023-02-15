using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Kinesia.Gestion.Editions.Dto;

namespace Kinesia.Gestion.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}