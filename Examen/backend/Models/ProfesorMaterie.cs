using backend.Models.Base;

namespace backend.Models
{
    public class ProfesorMaterie: BaseEntity
    {
        public Profesor Profesor { get; set; }
        public Guid ProfesorId { get; set; }
        public Materie Materie { get; set; }
        public Guid MaterieId { get; set; }
    }
}
