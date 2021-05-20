using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            INSERT INTO planets
            (name, moons, color, starId)
            VALUES
            (@Name, @Moons, @Color, @StarId);
            SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, planet);
            planet.Id = id;
            return planet;
        }

        public void Delete(int id)
        {
            string sql = "DELETE FROM planets WHERE id = @id LIMIT 1;";
            _db.Execute(sql, new {id});
        }

        public Planet GetById(int id)
        {
            string sql = @"
            SELECT
            p.*,
            star.*
            FROM planets plan
            JOIN stars star WHERE plan.starId = star.id
            WHERE plan.id = @id;";
            return _db.Query<Planet, Star, Planet>(sql, (planet, star) =>
            {
                planet.Star = star;
                return planet;
            }, new {id}, splitOn: "id").FirstOrDefault();
        }
    }
}