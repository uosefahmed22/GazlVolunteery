using Account.Apis.Errors;
using Account.Core.Enums;
using Account.Core.Models.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Services.Content
{
    public interface INotificationService
    {
        Task<ApiResponse> CreateNotification(NotificationDto notificationDto);
        Task<NotificationDto> GetNotificationById(int id);
        Task<IEnumerable<NotificationDto>> GetAllNotifications();
        Task<ApiResponse> UpdateNotification(NotificationDto notificationDto);
        Task<ApiResponse> DeleteNotification(int id);
        Task<ApiResponse> MarkNotificationAsRead(int id);
    }
}
