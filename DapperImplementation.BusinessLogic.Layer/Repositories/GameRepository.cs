using DapperImplementation.BusinessLogic.Layer.Models;
using DapperImplementation.DataAccess.Layer.DAO;

namespace DapperImplementation.BusinessLogic.Layer.Repositories
{
    public class GameRepository
    {
        private readonly DapperDOA _dao;
        public GameRepository(DapperDOA dao)
        {
            _dao = dao;
        }

        public Task<int> CreateGameAsync(Game game)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteGameAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Game>> GetAllGameAsync()
        {
            string sql = "select * from GameData";
            var games = _dao.LoadDataAsync<Game>(sql, System.Data.CommandType.Text, new Dictionary<string, object>());
            return games;
        }

        public Task<int> UpdateGameAsync(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
