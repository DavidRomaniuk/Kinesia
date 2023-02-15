using Abp.AutoMapper;
using Kinesia.Gestion.Authorization.Users.Dto;

namespace Kinesia.Gestion.Mobile.MAUI.Models.User
{
    [AutoMapFrom(typeof(UserListDto))]
    public class UserListModel : UserListDto
    {
        public string Photo { get; set; }

        public string FullName => Name + " " + Surname;
    }
}
