using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Data
{
    public class Database
    {
        public List<MovieModel> GetAllMoviesResponses = new List<MovieModel>
        {
            new MovieModel { Id = 1, Name = "Spuderman 1" },
            new MovieModel { Id = 2, Name = "Spuderman 2"}
        };
        public List<ProjectionModel> GetAllProjectionsResponses = new List<ProjectionModel>
        {
            new ProjectionModel{ ProjectionId = 1 , Cinema = "Cineplex"},
            new ProjectionModel{ ProjectionId = 2 , Cinema = "CinemaCinema",MovieId = 1}

        };
        
    }
}
