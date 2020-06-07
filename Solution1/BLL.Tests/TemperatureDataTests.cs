
using ClassLibrary1.EF;
using ClassLibrary1.Entities;
using ClassLibrary1.Repositories.Interfaces;
using ClassLibrary1.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Moq;
using CCL.Security;
using CCL;
using BLL;
using CCL.Security.Identity;
using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace BLL.Tests
{
    public class TemperatureDataServiceTests
    {

        [Fact]
        public void Ctor_InputNull_ThrowArgumentNullException()
        {
            // Arrange
            IUnitOfWork nullUnitOfWork = null;

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => new TemperatureDataService(nullUnitOfWork));
        }

        [Fact]
        public void GetTemperatureDatas_UserIsAdmin_ThrowMethodAccessException()
        {
            // Arrange
            User user = new Admin(1, "test", 1);
            SecurityContext.SetUser(user);
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            ITemperatureDataService TemperatureDataService = new TemperatureDataService(mockUnitOfWork.Object);

            // Act
            // Assert
            Assert.Throws<MethodAccessException>(() => TemperatureDataService.GetTemperatureDatas(0));
        }

        [Fact]
        public void GetTemperatureDatas_TemperatureDataFromDAL_CorrectMappingToTemperatureDataDTO()
        {
            // Arrange
            User user = new Statistic(1, "test", 1);
            SecurityContext.SetUser(user);
            var TemperatureDataService = GetTemperatureDataService();

            // Act
            var actualTemperatureDataDto = TemperatureDataService.GetTemperatureDatas(0).First();

            // Assert
            Assert.True(
                actualTemperatureDataDto.TemperatureDataId == 1
                && actualTemperatureDataDto.Name == "testN"
                && actualTemperatureDataDto.Description == "testD"
                );
        }

        ITemperatureDataService GetTemperatureDataService()
        {
            var mockContext = new Mock<IUnitOfWork>();
            var expectedTemperatureData = new TemperatureData() { TemperatureDataId = 1, Name = "testN", Description = "testD", OSBBID = 2 };
            var mockDbSet = new Mock<ITemperatureDataRepository>();
            mockDbSet.Setup(z =>
                z.Find(
                    It.IsAny<Func<TemperatureData, bool>>(),
                    It.IsAny<int>(),
                    It.IsAny<int>()))
                  .Returns(
                    new List<TemperatureData>() { expectedTemperatureData }
                    );
            mockContext
                .Setup(context =>
                    context.TemperatureDatas)
                .Returns(mockDbSet.Object);

            ITemperatureDataService TemperatureDataService = new TemperatureDataService(mockContext.Object);

            return TemperatureDataService;
        }
    }
}
