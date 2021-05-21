using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public Species GetById(int id)
        {
            string sql = @"
            SELECT 
            specs.*,
            plans.*
            FROM species specs
            JOIN planets plans ON specs.planetId = plans.id
            WHERE specs.id = @id;";
            return _db.Query<Species, Planet, Species>(sql, (species, planet) =>
            {
                species.Planet = planet;
                return species;
            }, new {id}, splitOn: "id").FirstOrDefault();
        }

        public Species Create(Species species)
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

        public void Delete(int id)
        {
            string sql = "DELETE * FROM species WHERE id = @id LIMIT 1;";
            _db.Execute(sql);
        }
    }
}