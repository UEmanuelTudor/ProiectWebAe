namespace ProiectAEWeb.Models
{
    public class Marca
    {
        public int ID { get; set; }
        public string NumeMarca { get; set; }
        public ICollection<Serviciu>? Servicii { get; set; } //navigation property
    }
}
