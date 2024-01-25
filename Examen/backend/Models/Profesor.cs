using backend.Models.Base;
using backend.Models.Enums;

namespace backend.Models
{
    public class Profesor: BaseEntity
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public ICollection<ProfesorMaterie>? ProfesorMaterie { get; set; }
        public ProfEnum? profEnum { get; set; }

    }
}
