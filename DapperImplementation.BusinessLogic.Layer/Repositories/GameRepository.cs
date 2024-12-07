using DapperImplementation.BusinessLogic.Layer.Models;

namespace DapperImplementation.BusinessLogic.Layer.Repositories
{
    public class GameRepository : IGameRepository
    {
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
            throw new NotImplementedException();
        }

        public Task<int> UpdateGameAsync(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
