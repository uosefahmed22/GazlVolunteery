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
    public interface IVolunteerRepo
    {
        Task<Volunteer> GetByIdAsync(int id);
        Task<IEnumerable<Volunteer>> GetAllAsync();
        Task<ApiResponse> AddAsync(Volunteer volunteer);
        Task<ApiResponse> UpdateAsync(int id, Volunteer updatedVolunteer);
        Task<ApiResponse> DeleteAsync(int id);
        Task<ApiResponse> UpdateGoverrateAgencyMissionColor(GoverrateAgencyMissionUpdateRequest request);
        Task<ApiResponse> AddComplement(ComplementModel complement);
        Task<IEnumerable<ComplementModel>> GetAllComplements();
        Task<ComplementModel> GetComplementById(int id);
        Task<ApiResponse> DeleteComplement(int id);
        Task<ApiResponse> AddNews(NewsModel news);
        Task<IEnumerable<NewsModel>> GetAllNews();
        Task<NewsModel> GetNewsById(int id);
        Task<ApiResponse> DeleteNews(int id);
    }
}
