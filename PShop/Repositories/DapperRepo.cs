using System;
using System.Collections.Generic;
using PShop.Models.DBEntities;
using System.Data.SqlClient;
using System.Data;
using PShop.Infrastructure.Interfaces.Repository;
using Dapper;
using System.Linq;

namespace PShop.Repositories
{
    public class DapperRepo : IRepository<Players>
    {
        private readonly string  _connectionStr;
        public DapperRepo(string connectionStr)
        {
            _connectionStr = connectionStr;
        }
                
        public List<Players> All()
        {
            SqlMapper.GridReader res;
            IEnumerable<Players> players;
            IEnumerable<Teams> teams;
            IEnumerable<Sports> sports;
            using (IDbConnection _db = new SqlConnection(_connectionStr))
            {
                res = _db.QueryMultiple(
                "SELECT * FROM Players; " +
                "SELECT * FROM Teams;" +
                "SELECT * FROM Sports");

                players = res.Read<Players>();
                teams = res.Read<Teams>();
                sports = res.Read<Sports>();
            }

            foreach (var team in teams)
            {
                team.Sport = sports.FirstOrDefault(s => s.Id == team.SportId);
            }

            foreach (var player in players)
            {
                player.Team = teams.FirstOrDefault(t => t.Id == player.TeamId);
            }

            return players.ToList();

        }

        public Players GetById(Guid id)
        {
            throw new Exception();
            //return _db.Query<Players>("SELECT * FROM Player WHERE Id = @id", new { id }).FirstOrDefault();
        }
    }
}
