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
    public class AssociationService : IAssociationService
    {
        private readonly AppDBContext _context;
        public AssociationService(AppDBContext context)
        {
            _context = context;
        }
        public async Task<ApiResponse> AddAsync(AssociationModelDto association)
        {
            var newAssociation = new AssociationModel
            {
                Name = association.Name,
                Contact = association.Contact,
                Longitude = association.Longitude,
                Latitude = association.Latitude
            };

            await _context.Associations.AddAsync(newAssociation);
            await _context.SaveChangesAsync();

            return new ApiResponse(200, "Created Successfully");
        }

        public async Task<ApiResponse> DeleteAsync(int id)
        {
            var associationToDelete = await _context.Set<AssociationModel>().FindAsync(id);
            if (associationToDelete == null)
            {
                return new ApiResponse(400, "Association not found.");
            }

            _context.Associations.Remove(associationToDelete);
            await _context.SaveChangesAsync();

            return new ApiResponse(200, "Deleted Successfully");
        }

        public async Task<IEnumerable<AssociationModel>> GetAllAsync()
        {
            return await _context.Associations.ToListAsync();
        }

        public async Task<AssociationModel> GetByIdAsync(int id)
        {
            return await _context.Associations.FindAsync(id);
        }

        public async Task<ApiResponse> UpdateAsync(int id, AssociationModelDto updatedAssociation)
        {
            var existingAssociation = await _context.Set<AssociationModel>().FirstOrDefaultAsync(a => a.Id == id);
            if (existingAssociation == null)
            {
                return new ApiResponse(400, "Association not found");
            }

            existingAssociation.Name = updatedAssociation.Name;
            existingAssociation.Contact = updatedAssociation.Contact;
            existingAssociation.Longitude = updatedAssociation.Longitude;
            existingAssociation.Latitude = updatedAssociation.Latitude;

            await _context.SaveChangesAsync();
            return new ApiResponse(200, "Updated Successfully");
        }
    }
}
