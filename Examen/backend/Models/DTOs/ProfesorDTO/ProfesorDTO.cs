using backend.Models.Enums;

namespace backend.Models.DTOs.ProfesorDTO
{
    public class ProfesorDTO
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public ProfEnum? profEnum { get; set; }
    }
}
