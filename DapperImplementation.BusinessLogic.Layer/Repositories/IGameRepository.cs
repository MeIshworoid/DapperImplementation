using DapperImplementation.BusinessLogic.Layer.Models;

namespace DapperImplementation.BusinessLogic.Layer.Repositories
{
    public interface IGameRepository
    {
        Task<List<Game>> GetAllGameAsync();
        Task<int> CreateGameAsync(Game game);
        Task<int> UpdateGameAsync(Game game);
        Task<int> DeleteGameAsync(int id);
    }
}
