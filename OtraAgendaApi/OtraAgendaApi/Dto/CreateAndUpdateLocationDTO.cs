namespace OtraAgendaApi.Dto
{
    public class CreateAndUpdateLocationDTO
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? Description { get; set; }
    }
}
