using OtraAgendaApi.Dto;
using OtraAgendaApi.Entities;

namespace OtraAgendaApi.Data.Interfaces
{
    public interface IContactRepository
    {
        public List<Contact> GetAll();
        public void Create(CreateAndUpdateContactDTO dto);
        public void Update(CreateAndUpdateContactDTO dto);
        public void Delete(int id);


    }
}
