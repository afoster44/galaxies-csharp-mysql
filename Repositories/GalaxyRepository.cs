using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using galaxies.Models;
using Microsoft.AspNetCore.Mvc;

namespace galaxies.Repositories
{
    public class GalaxyRepository
    {
        private readonly IDbConnection _db;

        public GalaxyRepository(IDbConnection db)
        {
            _db = db;
        }

        public IEnumerable<Galaxy> GetAll()
        {
            string sql = "SELECT * FROM galaxies;";
            return _db.Query<Galaxy>(sql);
        }
    }
}