﻿using AutoMapper;
using OtraAgendaApi.Data.Interfaces;
using OtraAgendaApi.Dto;
using OtraAgendaApi.Entities;
using OtraAgendaApi.Models.Enum;

namespace OtraAgendaApi.Data.Repository.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly IMapper _mapper;
        private AgendaApiContext _context;

        public UserRepository(AgendaApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        //public static List<User> FakeUsers = new List<User>()
        //{
        //    new User()
        //    {
        //        Email = "asdas@hotmail.com",
        //        Name = "Pepe",
        //        Password = "passwordsegura",
        //        Id = 1,
        //    },

        //    new User()
        //    {
        //        Email = "lkjb@hotmail.com",
        //        Name = "Andres",
        //        Password = "passwordsegura1",
        //        Id = 2,
        //    }
        //};

        //public List<User> GetAll()
        //{
        //    return FakeUsers;
        //}

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
        public User? GetById(int userId)
        {
            return _context.Users.SingleOrDefault(u => u.Id == userId);
        }

        public void Create(CreateAndUpdateUserDTO dto)
        {
            _context.Users.Add(_mapper.Map<User>(dto));
        }
        //public bool Create(CreateAndUpdateUserDTO userDTO)
        //{
        //    User user = new User()
        //    {
        //        Name = userDTO.Name,
        //        LastName = userDTO.LastName,
        //        Email = userDTO.Email,
        //        Password = userDTO.Password,
        //        UserName = userDTO.UserName,
        //        //Id = userDTO.Id,
        //    };

        //    FakeUsers.Add(user);
        //    return true;
        //}

        //public User ValidateUser(string userName, string password)
        //{
        //    var userActual = FakeUsers.Single(u => u.UserName == userName);
        //    if (userActual.Password == password)
        //        return userActual;
        //    return userActual;
        //}

        public User? ValidateUser(AuthenticationRequestBody authRequestBody)
        {
            return _context.Users.FirstOrDefault(p => p.UserName == authRequestBody.UserName && p.Password == authRequestBody.Password);
        }
        //public void Delete(int id)
        //{
        //    _context.Users.Remove(_context.Users.Single(u => u.Id == id));
        //}

        public void Delete(int id)
        {
            _context.Users.Remove(_context.Users.Single(u => u.Id == id));
        }

        public void Update(CreateAndUpdateUserDTO dto)
        {
            _context.Users.Update(_mapper.Map<User>(dto));
        }

        public void Archive(int Id)
        {
            User user = _context.Users.FirstOrDefault(u => u.Id == Id);
            if (user != null)
            {
                user.state = State.Archived;
                _context.Update(user);
            }

        }
    }
}