using AutoMapper;
using OtraAgendaApi.Data.Repository.Interfaces;
using OtraAgendaApi.Dto;
using OtraAgendaApi.Entities;

namespace OtraAgendaApi.Data.Repository.Implementations
{
    public class LocationRepository : ILocationRepository
    {
        private AgendaApiContext _context;
        private readonly IMapper _mapper;

        public LocationRepository(AgendaApiContext context)
        {
            _context = context;
        }

        public List<Location> GetAll()
        {
            return _context.Locations.ToList();
        }

        public void Create(CreateAndUpdateLocationDTO dto)
        {

        }

        public void Update(CreateAndUpdateLocationDTO dto)
        {

        }

        public void Delete(int id)
        {
            _context.Locations.Remove(_context.Locations.Single(c => c.Id == id));
        }

    }
}