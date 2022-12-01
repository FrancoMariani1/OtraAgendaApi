using AutoMapper;
using OtraAgendaApi.Dto;
using OtraAgendaApi.Entities;

namespace OtraAgendaApi.Profiles
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, CreateAndUpdateContactDTO>();
        }
    }
}
