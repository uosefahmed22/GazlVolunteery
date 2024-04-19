using Account.Apis.Errors;
using Account.Core.Dtos.Content;
using Account.Core.Models.Content;
using Account.Core.Services.Content;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Account.Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        private readonly IVolunteerRepo _volunteerRepository;
        

        public ContentController(IVolunteerRepo volunteerRepo)
        {
            _volunteerRepository = volunteerRepo;
        }

        [HttpPost]
        //[Authorize]
        public async Task<IActionResult> AddVolunteerAsync(Volunteer volunteer)
        {
            try
            {
                await _volunteerRepository.AddAsync(volunteer);
                return Ok("Volunteer added successfully.");
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "An error occurred while adding the volunteer.");
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _volunteerRepository.DeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllVolunteers()
        {
                var volunteers = await _volunteerRepository.GetAllAsync();
                return Ok(volunteers);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Volunteer>> GetById(int id)
        {
            var volunteer = await _volunteerRepository.GetByIdAsync(id);
            if (volunteer == null)
            {
                return NotFound();
            }
            return volunteer;
        }
        [HttpPut("{id}")]
        //[Authorize]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Volunteer updatedVolunteer)
        {
            try
            {
                await _volunteerRepository.UpdateAsync(id, updatedVolunteer);
                return Ok(new ApiResponse(200, "Volunteer updated successfully."));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new ApiResponse(400, ex.Message));
            }
            catch (Exception)
            {
                return StatusCode(500, new ApiResponse(500, "An error occurred while updating the volunteer."));
            }
        }
        [HttpPut("UpdateGoverrateAgency")]
        //[Authorize]
        public async Task<ActionResult<ApiResponse>> UpdateGoverrateAgencyMissionColor(GoverrateAgencyMissionUpdateRequest request)
        {
            var response = await _volunteerRepository.UpdateGoverrateAgencyMissionColor(request);

            if (response.StatusCode == 200)
            {
                return Ok(response);
            }
            else if (response.StatusCode == 400)
            {
                return BadRequest(response);
            }
            else
            {
                return StatusCode(500, response);
            }
        }

        [HttpPost("AddComplement")]
        public async Task<IActionResult> AddComplement([FromBody] ComplementModel complementModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var response = await _volunteerRepository.AddComplement(complementModel);
                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return StatusCode(response.StatusCode, response);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse(500, $"An error occurred while adding complement: {ex.Message}"));
            }
        }

        [HttpGet("GetAllComplements")]
        public async Task<IActionResult> GetAllComplements()
        {
            try
            {
                var complements = await _volunteerRepository.GetAllComplements();
                return Ok(complements);
            }
            catch (Exception ex)
            {
                // Log the error or handle it as needed
                return StatusCode(500, new ApiResponse(500, $"An error occurred while fetching complements: {ex.Message}"));
            }
        }

        [HttpGet("GetComplementById/{id}")]
        public async Task<IActionResult> GetComplementById(int id)
        {
            try
            {
                var complement = await _volunteerRepository.GetComplementById(id);
                if (complement != null)
                {
                    return Ok(complement);
                }
                else
                {
                    return NotFound(new ApiResponse(404, "Complement not found"));
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse(500, $"An error occurred while fetching complement: {ex.Message}"));
            }
        }

        [HttpDelete("DeleteComplement/{id}")]
        public async Task<IActionResult> DeleteComplement(int id)
        {
            try
            {
                var response = await _volunteerRepository.DeleteComplement(id);
                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return NotFound(response);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse(500, $"An error occurred while deleting complement: {ex.Message}"));
            }
        }

        [HttpPost("AddNews")]
        public async Task<IActionResult> AddNews([FromBody] NewsModel newsModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var response = await _volunteerRepository.AddNews(newsModel);
                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return StatusCode(response.StatusCode, response);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse(500, $"حدث خطأ أثناء إضافة الخبر: {ex.Message}"));
            }
        }

        [HttpGet("GetAllNews")]
        public async Task<IActionResult> GetAllNews()
        {
            try
            {
                var news = await _volunteerRepository.GetAllNews();
                return Ok(news);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse(500, $"An error occurred while fetching all news articles: {ex.Message}"));
            }
        }
        [HttpGet("GetNewsById/{id}")]
        public async Task<IActionResult> GetNewsById(int id)
        {
            try
            {
                var news = await _volunteerRepository.GetNewsById(id);
                if (news != null)
                {
                    return Ok(news);
                }
                else
                {
                    return NotFound(new ApiResponse(404, "News article not found"));
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse(500, $"An error occurred while fetching news article: {ex.Message}"));
            }
        }
        [HttpDelete("DeleteNews/{id}")]
        public async Task<IActionResult> DeleteNews(int id)
        {
            try
            {
                var response = await _volunteerRepository.DeleteNews(id);
                if (response != null)
                {
                    return Ok(response);
                }
                else
                {
                    return NotFound(response);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ApiResponse(500, $"An error occurred while deleting news article: {ex.Message}"));
            }
        }

    }
}
