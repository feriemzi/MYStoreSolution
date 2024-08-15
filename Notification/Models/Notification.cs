#nullable disable
using NotificationAPI.Enums;
namespace NotificationAPI.Models;
public class Notification{
    public int id {get;set;}
    public string Message{get;set;}
    public string Reciver{get;set;}
    public NotificationType notificationType{get;set;}
    public int CreatedByUserId {get;set;}
}     