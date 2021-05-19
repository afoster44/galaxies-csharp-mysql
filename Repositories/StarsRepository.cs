using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        //get by id is odd when we need to do a table join and populate. You have to make sure to use FirstOrDefault() on the end of the Query because we are returning a singular object not a list which query expects a list returned.
        internal Star GetById(int id)
        {
            string sql = @"
            SELECT 
            star.*,
            galax.*
            FROM stars star
            JOIN galaxies galax ON star.galaxyId = galax.id
            WHERE star.id = @id;";
            return _db.Query<Star, Galaxy, Star>(sql, (star, galaxy) => 
            {
                star.Galaxy = galaxy;
                return star;
            }, new {id}, splitOn: "id").FirstOrDefault();
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

        internal void Delete(int id)
        {
            string sql = "DELETE FROM stars WHERE id = @id LIMIT 1;";
            _db.Execute(sql, new {id});
        }
    }
}