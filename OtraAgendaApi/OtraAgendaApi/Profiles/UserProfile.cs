using AutoMapper;
using OtraAgendaApi.Dto;
using OtraAgendaApi.Entities;

namespace OtraAgendaApi.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, CreateAndUpdateUserDTO>();
            CreateMap<GetUserByIdResponse, User>();
        }
    }
}
