using AutoMapper;
using backend.Models;
using backend.Models.DTOs.ProfesorDTO;
using backend.Repositories.ProfesorRepository;

namespace backend.Services.ProfesorService
{
    public class ProfesorService: IProfesorService
    {
        private readonly IProfesorRepository _profesorRepository;
        private readonly IMapper _mapper;

        public ProfesorService(IProfesorRepository profesorRepository, IMapper mapper)
        {
            _profesorRepository = profesorRepository;
            _mapper = mapper;
        }

        public async Task<List<Profesor>> GetAll()
        {
            return await _profesorRepository.GetAllAsync();
        }

        public async Task Create(ProfesorDTO profesor)
        {
            var vprof = _mapper.Map<Profesor>(profesor);    
            await _profesorRepository.CreateAsync(vprof);
            await _profesorRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _profesorRepository.DeleteById(id);
            _profesorRepository.SaveAsync();
        }

        public async Task Update(ProfesorUpdateDTO profesor)
        {
            var vprof = _mapper.Map<Profesor>(profesor);
            _profesorRepository.Update(vprof);
            await _profesorRepository.SaveAsync();
        }
    }
}
