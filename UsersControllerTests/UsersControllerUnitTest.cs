
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyApp.Controllers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsersWebApi_Module3WithMoq.Models;

namespace UsersControllerTests
{ 
    [TestClass]   // this is mohammed
    public class UsersControllerUnitTest
    {
        /// <returns></returns>
        [TestMethod]
        public async Task Create_ReturnsCreatedAtAction_WhenModelIsValid()
        {
            // Arrange
            var mockRepo = new Mock<IUserRepository>();
            var controller = new UsersController(mockRepo.Object);
            
            var newUser = new User
            {
                Name = "Test User",
                Username = "Mohammed",
                Email = "moal@test.dk",
                Password = "secret123"
            };

            mockRepo.Setup(r => r.AddAsync(It.IsAny<User>()))
                .Returns(Task.CompletedTask)
                .Verifiable();

            // Act
            var result = await controller.Create(newUser);

            // Assert
            var createdAt = result.Result as CreatedAtActionResult;
            Assert.IsNotNull(createdAt);
            var returnValue = createdAt.Value as User;
            Assert.IsNotNull(returnValue);
            Assert.AreEqual("Mohammed", returnValue.Username);

            mockRepo.Verify();
        }
    }

}
