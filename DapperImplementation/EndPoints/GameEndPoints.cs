using DapperImplementation.BusinessLogic.Layer.Repositories;
using DapperImplementation.DataAccess.Layer.DAO;
using DapperImplementation.DataAccess.Layer.Factory;

namespace DapperImplementation.EndPoints
{
    public static class GameEndPoints
    {
        public static void MapGameEndPoints(this IEndpointRouteBuilder builder)
        {
            builder.MapGet("games", async (SqlConnectionFactory sqlConnectionFactory) =>
            {
                var connection = sqlConnectionFactory.CreateConnection();
                DapperDOA dao = new DapperDOA(connection);
                GameRepository gameRepository = new GameRepository(dao);
                var games = await gameRepository.GetAllGameAsync();

                return Results.Ok(games);
            });
        }
    }
}
