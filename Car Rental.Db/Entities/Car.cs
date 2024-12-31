namespace Car_Rental.Db.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string ImagePath { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Color { get; set; } = string.Empty;
        public string LicensePlate { get; set; } = string.Empty;
        public decimal DailyRate { get; set; }
        public bool IsAvailable { get; set; }
        public CarType Type { get; set; }
        public ICollection<Rental> Rentals { get; set; } = [];
        public override string ToString()
        {
            return $"Car ID: {Id}\nManufacturer: {Manufacturer}\nModel: {Model}\nYear: {Year}\nColor: {Color}\nLicense Plate: {LicensePlate}\nDaily Rate: ${DailyRate}\nAvailable: {(IsAvailable ? "Yes" : "No")}";
        }
    }

}
