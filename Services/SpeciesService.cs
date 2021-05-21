using System;
using System.Collections.Generic;
using galaxies.Models;
using galaxies.Repositories;

namespace galaxies.Services
{
    public class SpeciesService
    {
        private readonly SpeciesRepository _repo;

        public SpeciesService(SpeciesRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Species> GetAll()
        {
            return _repo.GetAll();
        }

        public Species GetById(int id)
        {
            return _repo.GetById(id);
        }

        public Species Create(Species species)
        {
            return _repo.Create(species);
        }

        public string Delete(int id)
        {
            _repo.Delete(id);
            return "Deleted";
        }
    }
}