using Domain.Enums;
namespace Domain.Entities;

public class Order
{
    Guid Id { get; set; }
    string Address { get; set; }
    DateTime ScheduleDate { get; set; }
    OrderStatus Status { get; set; }
    String? Notes { get; set; } 
}