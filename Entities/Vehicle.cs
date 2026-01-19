using VehicleLogApp.Entities.Contracts;

namespace VehicleLogApp.Entities;
public class Vehicle:IEntity
{
    public int Id { get; set; }
    public string Plate { get; set; }
    public string Brand { get; set; }
    public int Year { get; set; }
    public string Username { get; set; }
    public IEnumerable<VehicleLog> VehicleLogs { get; set; }
}