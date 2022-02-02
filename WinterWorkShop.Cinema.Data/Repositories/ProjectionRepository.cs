using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public class ProjectionRepository : IProjectionRepository 
    {
        Database database = new Database();

        public List<ProjectionModel> GetAllProjections()
        {
            return database.GetAllProjectionsResponses;
        }
        public ProjectionModel GetProjectionById(int id)
        {
            var projection = database.GetAllProjectionsResponses.FirstOrDefault(x => x.ProjectionId == id);
            return projection;
        }
        public List<ProjectionModel> GetAllProjectionsByMovieId(int id)
        {

            return database.GetAllProjectionsResponses.Where(x => x.MovieId == id).ToList();
            
        }
    }
}
