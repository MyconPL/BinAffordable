namespace Domain.Common;

public class Truck : BaseEntity
{
    public string RegistrationNumber { get; set; }
    public string Brand { get; set; }

    public Truck(string registrationNumber, string brand)
    {
        RegistrationNumber = registrationNumber;
        Brand = brand;
    }
}