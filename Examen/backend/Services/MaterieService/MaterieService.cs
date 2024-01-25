using AutoMapper;
using backend.Models.DTOs.ProfesorDTO;
using backend.Models;
using backend.Repositories.ProfesorRepository;
using backend.Repositories.MaterieRepository;
using backend.Models.DTOs.MaterieDTO;

namespace backend.Services.MaterieService
{
    public class MaterieService: IMaterieService
    {
        private readonly IMaterieRepository _materieRepository;
        private readonly IMapper _mapper;

        public MaterieService(IMaterieRepository materieRepository, IMapper mapper)
        {
            _materieRepository = materieRepository;
            _mapper = mapper;
        }

        public async Task<List<Materie>> GetAll()
        {
            return await _materieRepository.GetAllAsync();
        }

        public async Task Create(MaterieDTO materie)
        {
            var vmaterie = _mapper.Map<Materie>(materie);
            await _materieRepository.CreateAsync(vmaterie);
            await _materieRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _materieRepository.DeleteById(id);
            _materieRepository.SaveAsync();
        }

        public async Task Update(MaterieUpdateDTO materie)
        {
            var vmaterie = _mapper.Map<Materie>(materie);
            _materieRepository.Update(vmaterie);
            await _materieRepository.SaveAsync();
        }
    }
}
