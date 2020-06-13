using System;
using Xunit;
using ClassLibrary1.Repositories.Interfaces;
using ClassLibrary1.EF;
using Microsoft.EntityFrameworkCore;
using ClassLibrary1.Entities;
using ClassLibrary1.Repositories.Impl;
using System.Linq;
using Moq;

namespace DAL.Tests
{
    class TestTemperatureDataRepository
        : BaseRepository<TemperatureData>
    {
        public TestTemperatureDataRepository(DbContext context)
            : base(context)
        {
        }
    }

    public class BaseRepositoryUnitTests
    {

        [Fact]
        public void Create_InputTemperatureDataInstance_CalledAddMethodOfDBSetWithTemperatureDataInstance()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<InquiryContext>()
                .Options;
            var mockContext = new Mock<InquiryContext>(opt);
            var mockDbSet = new Mock<DbSet<TemperatureData>>();
            mockContext
                .Setup(context =>
                    context.Set<TemperatureData>(
                        ))
                .Returns(mockDbSet.Object);
            //EFUnitOfWork uow = new EFUnitOfWork(mockContext.Object);
            var repository = new TestTemperatureDataRepository(mockContext.Object);

            TemperatureData expectedTemperatureData = new Mock<TemperatureData>().Object;

            //Act
            repository.Create(expectedTemperatureData);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Add(
                    expectedTemperatureData
                    ), Times.Once());
        }

        [Fact]
        public void Delete_InputId_CalledFindAndRemoveMethodsOfDBSetWithCorrectArg()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<InquiryContext>()
                .Options;
            var mockContext = new Mock<InquiryContext>(opt);
            var mockDbSet = new Mock<DbSet<TemperatureData>>();
            mockContext
                .Setup(context =>
                    context.Set<TemperatureData>(
                        ))
                .Returns(mockDbSet.Object);
            //EFUnitOfWork uow = new EFUnitOfWork(mockContext.Object);
            //ITemperatureDataRepository repository = uow.TemperatureDatas;
            var repository = new TestTemperatureDataRepository(mockContext.Object);

            TemperatureData expectedTemperatureData = new TemperatureData() { TemperatureDataID = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedTemperatureData.TemperatureDataID)).Returns(expectedTemperatureData);

            //Act
            repository.Delete(expectedTemperatureData.TemperatureDataID);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedTemperatureData.TemperatureDataID
                    ), Times.Once());
            mockDbSet.Verify(
                dbSet => dbSet.Remove(
                    expectedTemperatureData
                    ), Times.Once());
        }

        [Fact]
        public void Get_InputId_CalledFindMethodOfDBSetWithCorrectId()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<InquiryContext>()
                .Options;
            var mockContext = new Mock<InquiryContext>(opt);
            var mockDbSet = new Mock<DbSet<TemperatureData>>();
            mockContext
                .Setup(context =>
                    context.Set<TemperatureData>(
                        ))
                .Returns(mockDbSet.Object);

            TemperatureData expectedTemperatureData = new TemperatureData() { TemperatureDataID = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedTemperatureData.TemperatureDataID))
                    .Returns(expectedTemperatureData);
            var repository = new TestTemperatureDataRepository(mockContext.Object);

            //Act
            var actualTemperatureData = repository.Get(expectedTemperatureData.TemperatureDataID);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedTemperatureData.TemperatureDataID
                    ), Times.Once());
            Assert.Equal(expectedTemperatureData, actualTemperatureData);
        }


    }
}
