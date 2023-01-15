namespace ProiectAEWeb.Models
{
    public class Personal
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public ICollection<Serviciu>? Servicii { get; set; } //navigation property
    }
}
