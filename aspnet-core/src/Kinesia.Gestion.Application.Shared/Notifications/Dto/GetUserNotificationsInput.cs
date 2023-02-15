using System;
using Abp.Notifications;
using Kinesia.Gestion.Dto;

namespace Kinesia.Gestion.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}