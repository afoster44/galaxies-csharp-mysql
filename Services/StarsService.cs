using System;
using System.Collections.Generic;
using galaxies.Models;
using galaxies.Repositories;

namespace galaxies.Services
{
    public class StarsService
    {
        private readonly StarsRepository _repo;

        public StarsService(StarsRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Star> GetAll()
        {
            return _repo.GetAll();
        }

        public Star GetById(int id)
        {
            return _repo.GetById(id);
        }

        public Star Create(Star star)
        {
            return _repo.Create(star);
        }

        public string Delete(int id)
        {
            _repo.Delete(id);
            return "Deleted";
        }
    }
}