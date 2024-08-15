#nullable disable 
using NotificationAPI.Enums;
namespace NotificationAPI.DTOs;
public class SendNotificationDto{
    public string Message{get;set;}
    public string Reciver{get;set;}
    public NotificationType notificationType{get;set;}
}