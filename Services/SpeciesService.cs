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

        public Species Create(Species species)
        {
            return _repo.Create(species);
        }
    }
}