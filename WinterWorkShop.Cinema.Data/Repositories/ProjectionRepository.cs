using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public class ProjectionRepository : IProjectionRepository
    {
        public List<ProjectionModel> GetAllProjections()
        {
            Database database = new Database();
            return database.GetAllProjectionsResponses;
        }
    }
}
