using Microsoft.EntityFrameworkCore;
using Panda.Data;
using Panda.Domain;
using Panda.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Panda.Tests.Services
{
    public class UsersTests
    {
        private List<PandaUser> GetTestData()
        {
            return new List<PandaUser>
            {
                new PandaUser
                {
                    UserName = "TestUser1",
                    Email = "test1@test.com",
                    UserRole = new PandaUserRole{ Name = "Admin"}
                },
                new PandaUser
                {
                    UserName = "TestUser2",
                    Email = "test2@test.com",
                    UserRole = new PandaUserRole{ Name = "User"}
                }
            };
        }

        private void SeedTestData(PandaDbContext context)
        {
            context.Users.AddRange(GetTestData());
            context.SaveChanges();
        }

        [Fact]
        public void TestGetAllUsers_WithTwoTestUsers_ShouldReturnAllUsers()
        {
            var options = new DbContextOptionsBuilder<PandaDbContext>()
                .UseInMemoryDatabase(databaseName:Guid.NewGuid().ToString())
                .Options;

            var context = new PandaDbContext(options);

            SeedTestData(context);

            var service = new UsersService(context);

            var expectedData = GetTestData();
            var actualData = service.GetAllUsers();

            Assert.Equal(expectedData.Count, actualData.Count);

            foreach (var user in actualData)
            {
                Assert.True(expectedData.Any(u => user.UserName == u.UserName
                && user.Email == u.Email
                && user.UserRole.Name == u.UserRole.Name),
                 "UsersService GetAllUsers() method not correct!");
            }
        }

        [Fact]
        public void TestGetUser_ShouldGetCorrectUser()
        {
            var options = new DbContextOptionsBuilder<PandaDbContext>()
             .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
             .Options;

            var context = new PandaDbContext(options);

            SeedTestData(context);

            var service = new UsersService(context);

            var expectedUser = context.Users.FirstOrDefault(y => y.UserName == "TestUser1");
            var actualUser = service.GetUser("TestUser1");

            Assert.Equal(expectedUser, actualUser);
        }


        [Fact]
        public void TestGetUser_ShouldReturnNull()
        {
            var options = new DbContextOptionsBuilder<PandaDbContext>()
             .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
             .Options;

            var context = new PandaDbContext(options);

            SeedTestData(context);

            var service = new UsersService(context);

            var expectedUser = context.Users.FirstOrDefault(y => y.UserName == "TestUser3");

            Assert.Null(expectedUser);
        }
    }
}
