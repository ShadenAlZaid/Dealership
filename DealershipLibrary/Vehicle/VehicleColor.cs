namespace DealershipLibrary.Vehicle
{
    public class VehicleColor
    {
        public int VehicleColorId { get; set; }
        public VehicleColor(string Name)
        {
            this.Name = Name;
        }

        public VehicleColor(int VehicleColorId, string Name)
        {
            this.VehicleColorId = VehicleColorId;
            this.Name = Name;
        }
        public string Name { get; set; }
    }

    public enum VehicleColorsEnum
    {
        Black = 1,
        White = 2,
        Red = 3,
        Blue = 4,
        Silver = 5
    }
}