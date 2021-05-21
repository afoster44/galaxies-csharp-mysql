using System;
using System.Collections.Generic;
using galaxies.Controllers;
using galaxies.Models;
using galaxies.Repositories;

namespace galaxies.Services
{
    public class PlanetsSpeciesService
    {
        private readonly PlanetsSpeciesRepository _repo;

        public PlanetsSpeciesService(PlanetsSpeciesRepository repo)
        {
            _repo = repo;
        }

        public PlanetsSpecies GetById(int id)
        {
            return _repo.GetById(id);
        }

        public PlanetsSpecies Create(PlanetsSpecies newPS)
        {
            return _repo.Create(newPS);
        }
    }
}