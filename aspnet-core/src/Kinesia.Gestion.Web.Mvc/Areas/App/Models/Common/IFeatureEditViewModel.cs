using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Kinesia.Gestion.Editions.Dto;

namespace Kinesia.Gestion.Web.Areas.App.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}