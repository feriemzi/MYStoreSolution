using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using NotificationAPI.DTOs;
using NotificationAPI.Models;

namespace NotificationAPI.Controllers;


public class NotificationController:BaseController
{
    [HttpPost]
    [Route("Send")]
    [Consumes(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public bool Send([FromBody]SendNotificationDto dto)
    {
        var notification =new Models.Notification(){
            Message =dto.Message,
            Reciver = dto.Reciver,
            notificationType = dto.notificationType 
        };

        return true;
    }
}