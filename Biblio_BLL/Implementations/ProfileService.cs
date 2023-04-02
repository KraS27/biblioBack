using Biblio_BLL.Interfaces;
using Biblio_DAL.Interfaces;
using Biblio_DOMAIN.Entities.DB;
using Biblio_DOMAIN.Entities.DTO;
using Biblio_DOMAIN.Response;
using Microsoft.EntityFrameworkCore;

namespace Biblio_BLL.Implementations
{
    public class ProfileService : IProfileService
    {
        private readonly IBaseRepository<Profile> _profileRepository;

        public ProfileService(IBaseRepository<Profile> profileRepository)
        {
            _profileRepository = profileRepository;
        }

        public async Task<ProfileResponse> GetProfile(int UserId)
        {
            try
            {
                var profile = await _profileRepository.GetAll().Include(p => p.User.Location).FirstOrDefaultAsync(p => p.UserId == UserId);
                var profileDTO = new ProfileDTO
                {
                    Id = profile.UserId,
                    Description = profile.Description,
                    ProfileImg = profile.ProfileImg,
                    Status = profile.Status,
                    FirstName= profile.FirstName,
                    LastName= profile.LastName,
                    Location = new LocationDTO
                    {
                        Country = profile.User.Location.Country,
                        City = profile.User.Location.City,
                    }
                };
                return new ProfileResponse
                {
                    Profile = profileDTO,
                    Status = Biblio_DOMAIN.Enum.ResponseStatus.Ok
                };
            }
            catch (Exception ex)
            {
                return new ProfileResponse
                {
                    Description = $"[GetProfile]: {ex.Message}",
                    Status = Biblio_DOMAIN.Enum.ResponseStatus.InternalServerError
                };
            }
        }
    }
}
