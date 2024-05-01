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
    public interface IAssociationService
    {
        Task<AssociationModel> GetByIdAsync(int id);
        Task<IEnumerable<AssociationModel>> GetAllAsync();
        Task<ApiResponse> AddAsync(AssociationModelDto association);
        Task<ApiResponse> UpdateAsync(int id, AssociationModelDto updatedAssociation);
        Task<ApiResponse> DeleteAsync(int id);
    }
}
