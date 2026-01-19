using VehicleLogApp.Entities.Contracts;

namespace VehicleLogApp.Entities;
public class VehicleLog:IEntity
{
    public int Id { get; set; }
    public int VehicleId { get; set; }
    public string DriverName { get; set; }
    public string Destination { get; set; }
    public DateTime ExitDateTime { get; set; }
    public long ExitKm { get; set; }
    public DateTime? EntryDateTime { get; set; }
    public long EntryKm { get; set; }
    public int DifferenceKm { get; set; }

    public Vehicle Vehicle { get; set; }
}
