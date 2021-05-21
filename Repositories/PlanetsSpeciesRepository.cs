using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using galaxies.Models;

namespace galaxies.Repositories
{
    public class PlanetsSpeciesRepository
    {
        private readonly IDbConnection _db;

        public PlanetsSpeciesRepository(IDbConnection db)
        {
            _db = db;
        }

        public PlanetsSpecies GetById(int id)
        {
            string sql = "SELECT * FROM planetsspecies WHERE id = @id;";
            return _db.QueryFirstOrDefault<PlanetsSpecies>(sql, new {id});
        }

        public PlanetsSpecies Create(PlanetsSpecies newPS)
        {
            string sql = @"
                INSERT INTO planetsspecies
                (speciesId, planetId)
                VALUES
                (@SpeciesId, @PlanetId);
                SELECT LAST_INSERT_ID();";
                int id = _db.ExecuteScalar<int>(sql, newPS);
                newPS.Id = id;
                return newPS;
        }
    }
}