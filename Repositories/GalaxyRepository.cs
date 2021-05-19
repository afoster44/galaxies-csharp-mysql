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

        public Galaxy GetById(int id)
        {
            string sql = "SELECT * FROM galaxies WHERE id = @id";
            return _db.QueryFirstOrDefault<Galaxy>(sql, new { id });
        }

        public Galaxy Create(Galaxy galaxy)
        {
            string sql = @"
            INSERT INTO galaxies
            (name, color, stellarContent)
            VALUES
            (@Name, @Color, @StellarContent);
            SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, galaxy);
            galaxy.Id = id;
            return galaxy;
        }

        internal void Delete(int id)
        {
            string sql = "DELETE FROM galaxies WHERE id = @id LIMIT 1;";
            _db.Execute(sql, new {id});
        }
    }
}