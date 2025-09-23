namespace MovieStoreASPNETCoreWebAPI.Entities
{
    public class Actor
    {
        public long Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Fortuna { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
