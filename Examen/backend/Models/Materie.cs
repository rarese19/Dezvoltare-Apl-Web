using backend.Models.Base;

namespace backend.Models
{
    public class Materie: BaseEntity
    {
        public string Nume { get; set; }
        public int NrCredite { get; set; }
        public ICollection<ProfesorMaterie>? ProfesorMaterie { get; set; }

    }
}
