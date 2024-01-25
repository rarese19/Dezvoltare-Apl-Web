using backend.Models;
using backend.Models.DTOs.MaterieDTO;
using backend.Models.DTOs.ProfesorDTO;
using backend.Models.DTOs.RelatieDTO;
using Microsoft.EntityFrameworkCore;

namespace backend.Helpers;

public class MapperProfile : AutoMapper.Profile
{
    public MapperProfile()
    {
        CreateMap<Profesor, ProfesorDTO>();
        CreateMap<ProfesorDTO, Profesor>()
            .ForMember(p => p.Id,
                opt => opt.MapFrom(src => new Guid()));

        CreateMap<Materie, MaterieDTO>();
        CreateMap<MaterieDTO, Materie>()
            .ForMember(m => m.Id,
                opt => opt.MapFrom(src => new Guid()));

        CreateMap<ProfesorUpdateDTO, Profesor>();
        CreateMap<MaterieUpdateDTO, Materie>();

        CreateMap<RelatieCreateDTO, ProfesorMaterie>()
            .ForMember(c => c.LastModified, opt =>
                opt.MapFrom(src => DateTime.Now))
            .ForMember(c => c.DateCreated, opt =>
                opt.MapFrom(src => DateTime.Now));
    }
}