using Lab3_23.Models.Base;

namespace Lab3_23.Models
{
    public class Masina: BaseEntity
    {
        public string? Marca { get; set; }
        public int Capacitate { get; set; }
        public int NumarLocuri {  get; set; }
    }
}
