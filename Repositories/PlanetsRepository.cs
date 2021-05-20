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
    }
}