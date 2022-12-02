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

        public Location GetById(int locationId)
        {
            return _context.Locations.SingleOrDefault(u => u.Id == locationId);
        }
        public void Create(CreateAndUpdateLocationDTO dto)
        {
            _context.Locations.Add(_mapper.Map<Location>(dto));
        }

        public void Update(CreateAndUpdateLocationDTO dto)
        {
            _context.Locations.Update(_mapper.Map<Location>(dto));
        }

        public void Delete(int id)
        {
            _context.Locations.Remove(_context.Locations.Single(c => c.Id == id));
        }

    }
}