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

        public Star Create(Star star)
        {
            return _repo.Create(star);
        }
    }
}