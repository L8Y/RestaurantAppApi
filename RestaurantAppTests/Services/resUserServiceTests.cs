using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RestaurantApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantApp.Models;
using Microsoft.EntityFrameworkCore;

namespace RestaurantApp.Services.Tests
{
    [TestClass()]
    public class resUserServiceTests
    {
        [TestMethod()]
        public void resUserExistTest()
        {
            // Arrange
            var email = "test@example.com";
            var password = "password123";
            var resUser = new List<ResUser>
            {
                new ResUser{ResId  = 1, Email = email, Password = password}

            }.AsQueryable();

            var mockSet = new Mock<DbSet<ResUser>>();
            var mockContext = new Mock<resturentContext>();
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.Provider).Returns(resUser.Provider);
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.Expression).Returns(resUser.Expression);
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.ElementType).Returns(resUser.ElementType);
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.GetEnumerator()).Returns(resUser.GetEnumerator());

            mockContext.Setup(c => c.ResUser).Returns(mockSet.Object);
            resUserService rs = new resUserService(mockContext.Object);


            // Act

            var result = rs.isUserExist(email, password);
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
            Assert.AreEqual(1, result.First().ResId);
            Assert.AreEqual(email, result.First().Email);
            Assert.AreEqual(password, result.First().Password);
        }

        [TestMethod()]
        public void resUserNotExistTest()
        {
            // Arrange
            var email = "test@example.com";
            var password = "password123";
            var resUser = new List<ResUser>
            {
                new ResUser{}

            }.AsQueryable();

            var mockSet = new Mock<DbSet<ResUser>>();
            var mockContext = new Mock<resturentContext>();
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.Provider).Returns(resUser.Provider);
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.Expression).Returns(resUser.Expression);
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.ElementType).Returns(resUser.ElementType);
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.GetEnumerator()).Returns(resUser.GetEnumerator());

            mockContext.Setup(c => c.ResUser).Returns(mockSet.Object);
            resUserService rs = new resUserService(mockContext.Object);


            // Act

            var result = rs.isUserExist(email, password);
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count());
        }
        [TestMethod()]
        public void emailUniqTest()
        {
            var email = "test@example.com";

            var resUser = new List<ResUser>
            {
                new ResUser{ResId  = 1, Email = "asda@gmail.com", Password = "asdasd"},
                new ResUser{ResId  = 2, Email = "12asd@gamilc.om", Password = "asdasdasd"},
                new ResUser{ResId  = 2, Email = "qweqwe@gmail.com", Password = "asda"}

            }.AsQueryable();

            var mockSet = new Mock<DbSet<ResUser>>();
            var mockContext = new Mock<resturentContext>();
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.Provider).Returns(resUser.Provider);
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.Expression).Returns(resUser.Expression);
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.ElementType).Returns(resUser.ElementType);
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.GetEnumerator()).Returns(resUser.GetEnumerator());

            mockContext.Setup(c => c.ResUser).Returns(mockSet.Object);
            resUserService rs = new resUserService(mockContext.Object);


            var result = rs.isEmailUniq(email);

            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void emailNotUniqTest()
        {
            var email = "asda@gmail.com";

            var resUser = new List<ResUser>
            {
                new ResUser{ResId  = 1, Email = "asda@gmail.com", Password = "asdasd"},
                new ResUser{ResId  = 2, Email = "12asd@gamilc.om", Password = "asdasdasd"},
                new ResUser{ResId  = 2, Email = "qweqwe@gmail.com", Password = "asda"}

            }.AsQueryable();

            var mockSet = new Mock<DbSet<ResUser>>();
            var mockContext = new Mock<resturentContext>();
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.Provider).Returns(resUser.Provider);
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.Expression).Returns(resUser.Expression);
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.ElementType).Returns(resUser.ElementType);
            mockSet.As<IQueryable<ResUser>>().Setup(m => m.GetEnumerator()).Returns(resUser.GetEnumerator());

            mockContext.Setup(c => c.ResUser).Returns(mockSet.Object);
            resUserService rs = new resUserService(mockContext.Object);


            var result = rs.isEmailUniq(email);

            Assert.IsTrue(result);
        }

    }
}