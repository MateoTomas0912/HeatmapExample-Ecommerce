using HeatMapBackend.Dto;
using HeatMapBackend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HeatMapBackend.Controllers
{
    [ApiController]
    [Route("api/heatmap")]
    public class HeatMapController : ControllerBase
    {
        private readonly IHandleDataRepository _handleDataRepository;

        public HeatMapController(IHandleDataRepository handleDataRepository)
        {
            _handleDataRepository = handleDataRepository;
        }

        [HttpPost]
        public IActionResult SaveHeatmapData([FromBody] List<HeatmapEvent> events)
        {
            if (events == null || events.Count == 0)
                return BadRequest("No data received");

            var existingData = _handleDataRepository.LoadData();
            if (existingData == null)
            {
                return StatusCode(500, "Failed to load existing data");
            }

            existingData.AddRange(events);
            var result = _handleDataRepository.SaveData(existingData);

            if (!result)
            {
                return StatusCode(500, "Failed to save data");
            }

            return Ok("Data saved");
        }


        [HttpGet]
        public IActionResult GetHeatmapData()
        {
            return Ok(_handleDataRepository.LoadData());
        }
    }
}
