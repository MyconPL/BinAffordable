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
    public DateTime DeliveryDate { get; set; }
    public DateTime PickupDate { get; set; }
    public OrderStatus Status { get; private set; }
    public ContainerSize ContainerSize { get; set; }
    public WasteCategory WasteCategory { get; set; }
    public String? Notes { get; set; }

    public BinOrder(
        string firstName,
        string lastName,
        string phoneNumber,
        string address,
        DateTime pickupDate,
        DateTime deliveryDate,
        DateTime status,
        ContainerSize containerSize,
        WasteCategory wasteCategory,
        string? notes = null)
    {
        Id = Guid.NewGuid();
        CustomerFirstName = firstName;
        CustomerLastName = lastName;
        PhoneNumber = phoneNumber;
        Address = address;
        DeliveryDate = deliveryDate;
        PickupDate = pickupDate;
        WasteCategory = wasteCategory;
        ContainerSize = containerSize;
        Notes = notes;
        Status = OrderStatus.Pending;
    }
}