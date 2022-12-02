using OtraAgendaApi.Dto;
using OtraAgendaApi.Entities;

namespace OtraAgendaApi.Data.Interfaces
{
    public interface IContactRepository
    {
        public List<Contact> GetAll(int id);
        public void Create(CreateAndUpdateContactDTO dto, int id);
        public void Update(CreateAndUpdateContactDTO dto);
        public void Delete(int id);


    }
}
