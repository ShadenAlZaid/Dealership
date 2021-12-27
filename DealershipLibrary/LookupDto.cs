namespace DealershipLibrary
{
    public class LookupDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public LookupDTO(int vehicleColorId, string name)
        {
            this.Id = vehicleColorId;
            this.Name = name;
        }
    }
}
