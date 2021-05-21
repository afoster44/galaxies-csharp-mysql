using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using galaxies.Models;

namespace galaxies.Repositories
{
    public class SpeciesRepository
    {
        private readonly IDbConnection _db;

        public SpeciesRepository(IDbConnection db)
        {
            _db = db;
        }

        public IEnumerable<Species> GetAll()
        {
            string sql = "SELECT * FROM species;";
            return _db.Query<Species>(sql);
        }

        internal Species Create(Species species)
        {
            string sql = @"
            INSERT INTO species
            (name, description, planetId)
            VALUES
            (@Name, @Description, @PlanetId);
            SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, species);
            species.Id = id;
            return species;
        }
    }
}