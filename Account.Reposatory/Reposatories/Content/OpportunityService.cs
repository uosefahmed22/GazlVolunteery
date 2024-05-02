using Account.Apis.Errors;
using Account.Core.Dtos.Content;
using Account.Core.Models.Content;
using Account.Core.Services.Content;
using Account.Reposatory.Data.Content;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Reposatory.Reposatories.Content
{
    public class OpportunityService : IOpportunityService
    {
        private readonly AppDBContext _context;
        public OpportunityService(AppDBContext context)
        {
            _context = context;
        }
        public async Task<ApiResponse> AddAsync(OpportunityModelDto opportunity)
        {
            var newOpportunity = new OpportunityModel
            {
                OpportunityType = opportunity.OpportunityType,
                ImplementingEntity = opportunity.ImplementingEntity,
                AvailableCount = opportunity.AvailableCount,
                ContactNumber = opportunity.ContactNumber,
                Longitude = opportunity.Longitude,
                Latitude = opportunity.Latitude
            };

            await _context.Opportunities.AddAsync(newOpportunity);
            await _context.SaveChangesAsync();

            return new ApiResponse(200, "Created Successfully");
        }
        public async Task<ApiResponse> DeleteAsync(int id)
        {
            var opportunityToDelete = await _context.Set<OpportunityModel>().FindAsync(id);
            if (opportunityToDelete == null)
            {
                return new ApiResponse(400, "Opportunity not found.");
            }

            _context.Opportunities.Remove(opportunityToDelete);
            await _context.SaveChangesAsync();

            return new ApiResponse(200, "Deleted Successfully");
        }
        public async Task<IEnumerable<OpportunityModel>> GetAllAsync()
        {
            return await _context.Opportunities.ToListAsync();
        }
        public async Task<OpportunityModel> GetByIdAsync(int id)
        {
            return await _context.Opportunities.FindAsync(id);
        }
        public async Task<ApiResponse> UpdateAsync(int id, OpportunityModelDto updatedOpportunity)
        {
            var existingOpportunity = await _context.Opportunities.FindAsync(id);
            if (existingOpportunity == null)
            {
                return new ApiResponse(400, "Opportunity not found.");
            }

            existingOpportunity.OpportunityType = updatedOpportunity.OpportunityType;
            existingOpportunity.ImplementingEntity = updatedOpportunity.ImplementingEntity;
            existingOpportunity.AvailableCount = updatedOpportunity.AvailableCount;
            existingOpportunity.ContactNumber = updatedOpportunity.ContactNumber;
            existingOpportunity.Longitude = updatedOpportunity.Longitude;
            existingOpportunity.Latitude = updatedOpportunity.Latitude;

            _context.Opportunities.Update(existingOpportunity);
            await _context.SaveChangesAsync();

            return new ApiResponse(200, "Updated Successfully");
        }
    }
}
