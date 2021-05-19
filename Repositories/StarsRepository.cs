using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using galaxies.Models;

namespace galaxies.Repositories
{
    public class StarsRepository
    {
        private readonly IDbConnection _db;

        public StarsRepository(IDbConnection db)
        {
            _db = db;
        }

        public IEnumerable<Star> GetAll()
        {
            string sql = @"
            SELECT 
            star.*,
            galax.*
            FROM stars star
            JOIN galaxies galax ON star.galaxyId = galax.id;";
            return _db.Query<Star, Galaxy, Star>(sql, (star, galaxy) =>
            {
                star.Galaxy = galaxy;
                return star;
            }, splitOn: "id");
        }

        public Star Create(Star star)
        {
            string sql = @"
            INSERT INTO stars
            (name, age, size, mass, galaxyId)
            VALUES
            (@Name, @Age, @Size, @Mass, @GalaxyId);
            SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, star);
            star.Id = id;
            return star;
        }
    }
}