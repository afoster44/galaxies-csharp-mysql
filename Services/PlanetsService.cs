using System;
using System.Collections.Generic;
using galaxies.Models;
using galaxies.Repositories;

namespace galaxies.Services
{
    public class PlanetsService
    {
        private readonly PlanetsRepository _repo;

        public PlanetsService(PlanetsRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Planet> GetAll()
        {
            return _repo.GetAll();
        }
        public Planet GetById(int id)
        {
            return _repo.GetById(id);
        }

        public Planet Create(Planet planet)
        {
            return _repo.Create(planet);
        }
    }
}