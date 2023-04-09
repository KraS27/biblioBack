using Biblio_BLL.Implementations;
using Biblio_DAL.Implementations;
using Biblio_DAL.Interfaces;
using Biblio_DOMAIN.Entities.DB;
using MockQueryable.Moq;
using Moq;
using Xunit;

namespace Biblio_TESTS.BIBLIO_BLL_TESTS
{
    public class UserServiceTests
    {
        [Fact]
        public async Task GetAllUsersReturnOkResponseStatusAsync()
        {
            //Arrange
                                   
            var mock = new Mock<IBaseRepository<User>>();
            mock.Setup(repo => repo.GetAll()).Returns(GetTestUsers());
            var userService = new UserService(mock.Object);

            //Act
            int page = 1;
            int usersCount = 6;
            var result = await userService.GetAllUsers(page, usersCount);

            //Assert
            Assert.Equal(Biblio_DOMAIN.Enum.ResponseStatus.Ok, result.Status);
        }

        [Fact]
        public async Task GetAllUsersReturnNotFoundResponseStatusAsync()
        {
            //Arrange
            var mock = new Mock<IBaseRepository<User>>();
            mock.Setup(repo => repo.GetAll()).Returns(GetTestUsers());
            var userService = new UserService(mock.Object);

            //Act
            int page = -1;
            int usersCount = 6;
            var result = await userService.GetAllUsers(page, usersCount);

            //Assert
            Assert.Equal(Biblio_DOMAIN.Enum.ResponseStatus.NotFound, result.Status);
        }



        private IQueryable<User> GetTestUsers() 
        {
            var users = new List<User>()
            {
                new User()
                {
                    Id  = 1,
                    Email= "test1@gmai.com",
                    LocationId = 1,
                    UserName = "kavabanga",
                    Location = null,
                    UserProfile = null
                },
                new User()
                {
                    Id  = 2,
                    Email= "test2@gmai.com",
                    LocationId = 2,
                    UserName = "kilokill",
                    Location = null,
                    UserProfile = null
                },
                new User()
                {
                    Id  = 3,
                    Email= "test3@gmai.com",
                    LocationId = 1,
                    UserName = "pupa",
                    Location = null,
                    UserProfile = null
                },
                new User()
                {
                    Id  = 4,
                    Email= "test4@gmai.com",
                    LocationId = 3,
                    UserName = "Kiril",
                    Location = null,
                    UserProfile = null
                },
                new User()
                {
                    Id  = 5,
                    Email= "test5@gmai.com",
                    LocationId = 2,
                    UserName = "ChackaLaca",
                    Location = null,
                    UserProfile = null
                },
                new User()
                {
                    Id  = 6,
                    Email= "test6@gmai.com",
                    LocationId = 2,
                    UserName = "PikaChicka",
                    Location = null,
                    UserProfile = null
                },
            };

            return users.AsQueryable();
        }
    }
}
