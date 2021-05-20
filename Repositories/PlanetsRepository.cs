using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using galaxies.Models;

namespace galaxies.Repositories
{
    public class PlanetsRepository
    {
        private readonly IDbConnection _db;

        public PlanetsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<Planet> GetAll()
        {
            string sql = "SELECT * FROM planets;";
            return _db.Query<Planet>(sql);
        }

        internal Planet Create(Planet planet)
        {
            string sql = @"
            INSERT INTO
            (name, moons, color, starId)
            VALUES
            (@Name, @Moons, @Color, @StarId);
            SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, planet);
            planet.Id = id;
            return planet;
        }
    }
}