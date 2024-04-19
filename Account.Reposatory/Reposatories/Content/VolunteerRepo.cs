using Account.Apis.Errors;
using Account.Core.Dtos.Content;
using Account.Core.Enums;
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
    public class VolunteerRepo : IVolunteerRepo
    {
        private readonly AppDBContext _context;
        public VolunteerRepo(AppDBContext context)
        {
            _context = context;
        }
        #region Voluteers
        public async Task<ApiResponse> AddAsync(Volunteer volunteer)
        {

            var newVolunteer = new Volunteer
            {
                Name = volunteer.Name,
                ExecutingEntity = volunteer.ExecutingEntity,
                RequestType = volunteer.RequestType,
                ContactNumbers = volunteer.ContactNumbers,
                Longitude = volunteer.Longitude,
                Latitude = volunteer.Latitude,
                SaudiNationalID = volunteer.SaudiNationalID
            };

            await _context.Set<Volunteer>().AddAsync(newVolunteer);

            await _context.SaveChangesAsync();
            return new ApiResponse(200, "Created Successfuly");
        }
        public async Task<ApiResponse> DeleteAsync(int id)
        {
            var volunteerToDelete = await _context.Set<Volunteer>().FindAsync(id);
            if (volunteerToDelete == null)
            {
                return new ApiResponse(400, "Volunteer not found.");
            }

            _context.Set<Volunteer>().Remove(volunteerToDelete);
            await _context.SaveChangesAsync();
            return new ApiResponse(200, "Deleted Successufly");
        }
        public async Task<IEnumerable<Volunteer>> GetAllAsync()
        {
            return await _context.Volunteers.ToListAsync();
        }
        public async Task<Volunteer> GetByIdAsync(int id)
        {
            return await _context.Volunteers.FindAsync(id);
        }
        public async Task<ApiResponse> UpdateAsync(int id, Volunteer updatedVolunteer)
        {
            var existingVolunteer = await _context.Volunteers.FirstOrDefaultAsync(v => v.Id == id);
            if (existingVolunteer == null)
            {
                return new ApiResponse(400, "Volunteer not found");
            }

            existingVolunteer.Name = updatedVolunteer.Name;
            existingVolunteer.ExecutingEntity = updatedVolunteer.ExecutingEntity;
            existingVolunteer.RequestType = updatedVolunteer.RequestType;
            existingVolunteer.ContactNumbers = updatedVolunteer.ContactNumbers;
            existingVolunteer.Longitude = updatedVolunteer.Longitude;
            existingVolunteer.Latitude = updatedVolunteer.Latitude;
            existingVolunteer.SaudiNationalID = updatedVolunteer.SaudiNationalID;

            await _context.SaveChangesAsync();
            return new ApiResponse(200, "updatedSuccesfully");
        }
        public async Task<ApiResponse> UpdateGoverrateAgencyMissionColor(GoverrateAgencyMissionUpdateRequest request)
        {
            try
            {
                var existingMission = await _context.Volunteers
                    .FirstOrDefaultAsync(m => m.Latitude == request.Latitude && m.Longitude == request.Longitude);

                if (existingMission == null)
                {
                    return new ApiResponse(400, "The provided latitude and longitude do not exist in the database.");
                }

                existingMission.Color = GetColorFromCaseType(request.CaseType);

                await _context.SaveChangesAsync();

                return new ApiResponse(200, "Updated Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex}");

                return new ApiResponse(500, "An error occurred while updating the data.");
            }
        }
        private string GetColorFromCaseType(CaseType caseType)
        {
            switch (caseType)
            {
                case CaseType.Red:
                    return "Red";
                case CaseType.Green:
                    return "Green";
                case CaseType.Orange:
                    return "Orange";
                default:
                    return "Unknown";
            }
        }
        #endregion

        #region Complment
        public async Task<ApiResponse> AddComplement(ComplementModel complement)
        {
            try
            {
                var newComplement = new ComplementModel
                {
                    SenderName = complement.SenderName,
                    NationalId = complement.NationalId,
                    PhoneNumber = complement.PhoneNumber,
                    ComplaintDetails = complement.ComplaintDetails
                };

                _context.Complements.Add(newComplement);
                await _context.SaveChangesAsync();

                return new ApiResponse(200, "Complement added successfully");
            }
            catch (Exception ex)
            {
                // Log the error or handle it as needed
                return new ApiResponse(500, $"Error adding complement: {ex.Message}");
            }
        }
        public async Task<IEnumerable<ComplementModel>> GetAllComplements()
        {
            try
            {
                var complements = await _context.Complements.ToListAsync();
                return complements.Select(c => new ComplementModel
                {
                    Id = c.Id,
                    SenderName = c.SenderName,
                    NationalId = c.NationalId,
                    PhoneNumber = c.PhoneNumber,
                    ComplaintDetails = c.ComplaintDetails
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching all complements: {ex.Message}");
            }
        }
        public async Task<ComplementModel> GetComplementById(int id)
        {
            try
            {
                var complement = await _context.Complements.FindAsync(id);
                if (complement == null)
                {
                    return null;
                }

                return new ComplementModel
                {
                    Id = complement.Id,
                    SenderName = complement.SenderName,
                    NationalId = complement.NationalId,
                    PhoneNumber = complement.PhoneNumber,
                    ComplaintDetails = complement.ComplaintDetails
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching complement by ID: {ex.Message}");
            }
        }
        public async Task<ApiResponse> DeleteComplement(int id)
        {
            try
            {
                var complement = await _context.Complements.FindAsync(id);
                if (complement == null)
                {
                    return new ApiResponse(404, "Complement not found");
                }

                _context.Complements.Remove(complement);
                await _context.SaveChangesAsync();

                return new ApiResponse(200, "Complement deleted successfully");
            }
            catch (Exception ex)
            {
                return new ApiResponse(500, $"Error deleting complement: {ex.Message}");
            }
        }

        #endregion

        #region News
        public async Task<ApiResponse> AddNews(NewsModel news)
        {
            try
            {
                var newNews = new NewsModel
                {
                    Content = news.Content,
                    PictureUrl = news.PictureUrl
                };

                _context.News.Add(newNews);
                await _context.SaveChangesAsync();

                return new ApiResponse(200, "News added successfully");
            }
            catch (Exception ex)
            {
                return new ApiResponse(500, $"Error adding news: {ex.Message}");
            }
        }
        public async Task<IEnumerable<NewsModel>> GetAllNews()
        {
            try
            {
                var news = await _context.News.ToListAsync();
                return news.Select(n => new NewsModel
                {
                    Content = n.Content,
                    PictureUrl = n.PictureUrl
                });
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching all news articles: {ex.Message}");
            }
        }
        public async Task<NewsModel> GetNewsById(int id)
        {
            try
            {
                var news = await _context.News.FindAsync(id);
                if (news == null)
                {
                    return null;
                }

                return new NewsModel
                {
                    Content = news.Content,
                    PictureUrl = news.PictureUrl
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching news article by ID: {ex.Message}");
            }
        }
        public async Task<ApiResponse> DeleteNews(int id)
        {
            try
            {
                var news = await _context.News.FindAsync(id);
                if (news == null)
                {
                    return new ApiResponse(404, "News article not found");
                }

                _context.News.Remove(news);
                await _context.SaveChangesAsync();

                return new ApiResponse(200, "News article deleted successfully");
            }
            catch (Exception ex)
            {
                return new ApiResponse(500, $"Error deleting news article: {ex.Message}");
            }
        }


        #endregion


    }
}