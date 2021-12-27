namespace DealershipLibrary.Vehicle
{
    public class VehicleColor
    {
        public int VehicleColorId { get; set; }
        public VehicleColor(string name)
        {
            Name = name;
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