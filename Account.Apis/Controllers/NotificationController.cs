using Account.Apis.Errors;
using Account.Core.Enums;
using Account.Core.Services.Content;
using Account.Reposatory.Reposatories.Content;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Account.Apis.Controllers
{
    public class NotificationController : ApiBaseController
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost]
        public async Task<IActionResult> AddNotification([FromBody] NotificationDto notificationDto)
        {
            var response = await _notificationService.CreateNotification(notificationDto);

            if (response != null) 
            { 
                return Ok(response);
            }
            else
            {
                return BadRequest(new ApiResponse(404, "There was an issue adding the notification."));
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAllNotifications()
        {
            try
            {
                var notifications = await _notificationService.GetAllNotifications();
                return Ok(notifications);
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse(500, $"An error occurred while fetching notifications: {ex.Message}"));
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNotification(int id)
        {
            try
            {
                var response = await _notificationService.DeleteNotification(id);
                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return NotFound(new ApiResponse(404, "Notification not found"));
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse(500, $"An error occurred while fetching notifications: {ex.Message}"));

            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNotificationById(int id)
        {
            try
            {
                var notificationDto = await _notificationService.GetNotificationById(id);
                if (notificationDto != null)
                {
                    return Ok(notificationDto);
                }
                else
                {
                    return NotFound(new ApiResponse(404, "Notification not found"));
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse(500, $"An error occurred while fetching notification: {ex.Message}"));
            }
        }

        [HttpPut("{id}/mark-read")]
        public async Task<IActionResult> MarkNotificationAsRead(int id)
        {
            try
            {
                var response = await _notificationService.MarkNotificationAsRead(id);
                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return NotFound(response);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse(500, $"An error occurred while marking notification as read: {ex.Message}"));
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateNotification(int id, [FromBody] NotificationDto notificationDto)
        {
            try
            {
                if (id != notificationDto.Id)
                {
                    return BadRequest(new ApiResponse(400, "Invalid ID in request body"));
                }

                var response = await _notificationService.UpdateNotification(notificationDto);
                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return NotFound(response);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse(500, $"An error occurred while updating notification: {ex.Message}"));
            }
        }
    }
}
