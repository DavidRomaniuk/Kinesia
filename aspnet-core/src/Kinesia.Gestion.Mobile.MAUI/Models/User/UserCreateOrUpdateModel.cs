using Abp.AutoMapper;
using Kinesia.Gestion.Authorization.Users.Dto;

namespace Kinesia.Gestion.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(CreateOrUpdateUserInput))]
    public class UserCreateOrUpdateModel : CreateOrUpdateUserInput
    {

    }
}
