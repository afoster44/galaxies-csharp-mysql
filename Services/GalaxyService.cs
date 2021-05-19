using System;
using System.Collections.Generic;
using galaxies.Models;
using galaxies.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace galaxies.Services
{
    public class GalaxyService
    {
        private readonly GalaxyRepository _repo;

        public GalaxyService(GalaxyRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Galaxy> GetAll()
        {
           return _repo.GetAll();
        }

         public Galaxy GetById(int id)
        {
            return _repo.GetById(id);
        }

        public Galaxy Create(Galaxy galaxy)
        {
            return _repo.Create(galaxy);
        }

        public string Delete(int id)
        {
            _repo.Delete(id);
            return "Deleted";
        }
    }
}