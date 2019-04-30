﻿using AracKiralama.Data.Context;
using AracKiralama.Data.Infrastructure;
using AracKiralama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Data.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository()
        {
            _context = new DataContext();
        }
        public IEnumerable<User> GetAll()
        {
            return _context.Users.Select(s => s);
        }

        public User GetById(int id)
        {
            return _context.Users.Where(s => s.Id == id).FirstOrDefault();
        }

        public void Insert(User obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
