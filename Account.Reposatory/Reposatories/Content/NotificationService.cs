using Account.Apis.Errors;
using Account.Core.Dtos.Content;
using Account.Core.Models.Content;
using Account.Core.Services.Content;
using Account.Reposatory.Data.Content;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Reposatory.Reposatories.Content
{
    public class NotificationService : INotificationService
    {
        private readonly AppDBContext _context;

        public NotificationService(AppDBContext context)
        {
            _context = context;
        }
        public async Task<ApiResponse> CreateNotification(NotificationDto notificationDto)
        {
            try
            {
                var notification = new Notification
                {
                    Message = notificationDto.Message,
                    Date = DateTime.Now,
                    IsRead = false
                };

                _context.Notifications.Add(notification);
                await _context.SaveChangesAsync();
                return new ApiResponse(200, "Notification created successfully");
            }
            catch (Exception ex)
            {
                return new ApiResponse(404, $"Error creating notification: {ex.Message}");
            }
        }
        public async Task<IEnumerable<NotificationDto>> GetAllNotifications()
        {
            var notifications = await _context.Notifications.ToListAsync();
            return notifications.Select(n => new NotificationDto
            {
                Message = n.Message,
                Date = n.Date,
                IsRead = n.IsRead,
            });
        }
        public async Task<ApiResponse> DeleteNotification(int id)
        {
            try
            {
                var notificationToDelete = await _context.Notifications.FindAsync(id);
                if (notificationToDelete == null)
                {
                    return new ApiResponse(404, "Notification not found");
                }

                _context.Notifications.Remove(notificationToDelete);
                await _context.SaveChangesAsync();

                return new ApiResponse(200, "Notification deleted successfully");
            }
            catch (Exception ex)
            {
                return new ApiResponse(500, $"Error deleting notification: {ex.Message}");
            }
        }
        public async Task<NotificationDto> GetNotificationById(int id)
        {
            try
            {
                var notification = await _context.Notifications.FindAsync(id);
                if (notification == null)
                {
                    return null;
                }
                var notificationDto = new NotificationDto
                {
                    Message = notification.Message,
                    Date = notification.Date,
                    IsRead = notification.IsRead
                };
                return notificationDto;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching notification: {ex.Message}");
            }
        }
        public async Task<ApiResponse> MarkNotificationAsRead(int id)
        {
            try
            {
                var notification = await _context.Notifications.FindAsync(id);
                if (notification == null)
                {
                    return new ApiResponse(404, "Notification not found");
                }

                notification.IsRead = true;
                await _context.SaveChangesAsync();

                return new ApiResponse(200, "Notification marked as read successfully");
            }
            catch (Exception ex)
            {
                return new ApiResponse(500, $"Error marking notification as read: {ex.Message}");
            }
        }
        public async Task<ApiResponse> UpdateNotification(Notification Notification)
        {
            try
            {
                var notification = await _context.Notifications.FindAsync(Notification.Id);
                if (notification == null)
                {
                    return new ApiResponse(404, "Notification not found");
                }

                notification.Message = Notification.Message;
                notification.Date = Notification.Date;

                await _context.SaveChangesAsync();

                return new ApiResponse(200, "Notification updated successfully");
            }
            catch (Exception ex)
            {
                return new ApiResponse(500, $"Error updating notification: {ex.Message}");
            }
        }
    }
}
