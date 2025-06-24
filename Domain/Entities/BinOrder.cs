using System.ComponentModel;
using Domain.Enums;
namespace Domain.Entities;

public class BinOrder
{
    public Guid Id { get; set; }
    public string CustomerFirstName { get; set; }

    public string CustomerLastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public DateTime ScheduleDate { get; set; }
    public OrderStatus Status { get; private set; }
    public ContainerSize ContainerSize { get; set; }
    public WasteCategory WasteCategory { get; set; }
    public String? Notes { get; set; }

    public BinOrder(
        string firstName,
        string lastName,
        string phoneNumber,
        string address,
        DateTime scheduleDate,
        OrderStatus status,
        ContainerSize containerSize,
        WasteCategory wasteCategory,
        string notes)
    {
        Id = Guid.NewGuid();
        CustomerFirstName = firstName;
        CustomerLastName = lastName;
        PhoneNumber = phoneNumber;
        Address = address;
        ScheduleDate = scheduleDate;
        Status = OrderStatus.Pending;
    }
}