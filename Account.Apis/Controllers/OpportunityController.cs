using Account.Apis.Errors;
using Account.Core.Dtos.Content;
using Account.Core.Models.Content;
using Account.Core.Services.Content;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Account.Apis.Controllers
{
    public class OpportunityController : ApiBaseController
    {
        private readonly IOpportunityService _opportunityService;

        public OpportunityController(IOpportunityService opportunityService)
        {
            _opportunityService = opportunityService;
        }
        [HttpPost]
        public async Task<IActionResult> AddOpportunityAsync(OpportunityModelDto opportunity)
        {
            try
            {
                var response = await _opportunityService.AddAsync(opportunity);
                return StatusCode(response.StatusCode, response);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "An error occurred while adding the opportunity.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var response = await _opportunityService.DeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOpportunities()
        {
            var opportunities = await _opportunityService.GetAllAsync();
            return Ok(opportunities);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OpportunityModel>> GetByIdAsync(int id)
        {
            var opportunity = await _opportunityService.GetByIdAsync(id);
            if (opportunity == null)
            {
                return NotFound();
            }
            return Ok(opportunity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] OpportunityModelDto updatedOpportunity)
        {
            try
            {
                var response = await _opportunityService.UpdateAsync(id, updatedOpportunity);
                return StatusCode(response.StatusCode, response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new ApiResponse(400, ex.Message));
            }
            catch (Exception)
            {
                return StatusCode(500, new ApiResponse(500, "An error occurred while updating the opportunity."));
            }
        }
    }
}
