using Microsoft.AspNetCore.Mvc;
using WinterWorkShop.Cinema.Data.Repositories;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.API.Controllers
{
    [ApiController]
    [Route("projections")]
    public class ProjectionsController : BaseController
    {
        public readonly IProjectionRepository _projectionRepository;

        public ProjectionsController(IProjectionRepository projectionRepository)
        {
            _projectionRepository = projectionRepository;
        }
        [HttpGet]
        public List<ProjectionResponse> GetAllProjection()
        {
            var projections = _projectionRepository.GetAllProjections();
            var result = new List<ProjectionResponse>();
            foreach (var projection in projections)
            {
                result.Add(new ProjectionResponse { Projection = projection.ProjectionId, CinemaPlace = projection.Cinema });
            }
            return result;
        }

        [HttpGet("{id}")]
        public ActionResult<ProjectionResponse> GetProjectionById(int id)
        {
            var projection = _projectionRepository.GetProjectionById(id);
        var result = new ProjectionResponse()
        {
            Projection = projection.ProjectionId,
            CinemaPlace = projection.Cinema
        };

           return result;
        }
        [HttpGet("{GetProjectionsByMovieId}")]
        public ActionResult<List<ProjectionResponse>> GetAllProjectionsByMovieId(int id)
        {
            var projections = _projectionRepository.GetAllProjectionsByMovieId( id);
            var result = new List<ProjectionResponse>();
            foreach(var projection in projections)
            {
                result.Add( new ProjectionResponse { Projection = projection.ProjectionId, CinemaPlace =projection.Cinema }); ;
            }
            return result;
        }

    }
}