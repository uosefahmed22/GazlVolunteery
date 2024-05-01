using Account.Apis.Errors;
using Account.Core.Dtos.Content;
using Account.Core.Models.Content;
using Account.Core.Services.Content;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Account.Apis.Controllers
{
    public class AssociationsController : ApiBaseController
    {
        private readonly IAssociationService _associationService;

        public AssociationsController(IAssociationService associationService) {
            _associationService = associationService;
        }
        [HttpPost]
        public async Task<IActionResult> AddAssociationAsync(AssociationModelDto association)
        {
            try
            {
                await _associationService.AddAsync(association);
                return Ok("Association added successfully.");
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "An error occurred while adding the association.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _associationService.DeleteAsync(id);
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAssociations()
        {
            var associations = await _associationService.GetAllAsync();
            return Ok(associations);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AssociationModel>> GetById(int id)
        {
            var association = await _associationService.GetByIdAsync(id);
            if (association == null)
            {
                return NotFound();
            }
            return association;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] AssociationModelDto updatedAssociation)
        {
            try
            {
                await _associationService.UpdateAsync(id, updatedAssociation);
                return Ok(new ApiResponse(200, "Association updated successfully."));
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new ApiResponse(400, ex.Message));
            }
            catch (Exception)
            {
                return StatusCode(500, new ApiResponse(500, "An error occurred while updating the association."));
            }
        }
    }
}
