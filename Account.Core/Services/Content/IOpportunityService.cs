using Account.Apis.Errors;
using Account.Core.Dtos.Content;
using Account.Core.Models.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Core.Services.Content
{
    public interface IOpportunityService
    {
        Task<OpportunityModel> GetByIdAsync(int id);
        Task<IEnumerable<OpportunityModel>> GetAllAsync();
        Task<ApiResponse> AddAsync(OpportunityModelDto opportunity);
        Task<ApiResponse> UpdateAsync(int id, OpportunityModelDto updatedOpportunity);
        Task<ApiResponse> DeleteAsync(int id);
    }
}
