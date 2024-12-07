using DapperImplementation.DataAccess.Layer.Factory;

namespace DapperImplementation.EndPoints
{
    public static class GameEndPoints
    {
        public static void MapGameEndPoints(this IEndpointRouteBuilder builder)
        {
            builder.MapGet("games", async (SqlConnectionFactory sqlConnectionFactory) =>
            {
                //Game
            };
        }
    }
}
