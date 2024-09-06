using AutoMapper;
using FilmeApi.Data.Dtos;
using FilmeApi.Models;


namespace FilmeApi.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}