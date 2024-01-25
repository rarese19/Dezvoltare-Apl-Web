using AutoMapper;
using backend.Models;
using backend.Models.DTOs.RelatieDTO;
using backend.Repositories.ProfesorMaterieRepository;

namespace backend.Services.ProfesorMaterieService
{
    public class ProfesorMaterieService: IProfesorMaterieService
    {
        private readonly IProfesorMaterieRepository _profesorMaterieRepository;
        private readonly IMapper _mapper;

        public ProfesorMaterieService(IProfesorMaterieRepository profesorMaterieRepository, IMapper mapper)
        {
            _profesorMaterieRepository = profesorMaterieRepository;
            _mapper = mapper;
        }

        public async Task Create(RelatieCreateDTO relatieCreate)
        {
            await _profesorMaterieRepository.CreateAsync(_mapper.Map<ProfesorMaterie>(relatieCreate));
            await _profesorMaterieRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _profesorMaterieRepository.DeleteById(id);
            _profesorMaterieRepository.SaveAsync();
        }
    }
}
