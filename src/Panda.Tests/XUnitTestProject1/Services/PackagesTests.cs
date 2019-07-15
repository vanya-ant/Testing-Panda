using Microsoft.EntityFrameworkCore;
using Panda.App.Models.Package;
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
    public class PackagesTests
    {
        //void CreatePackage(Package package);

        //Package GetPackage(string id);

        //PackageStatus GetPackageStatus(string status);

        //void UpdatePackage(Package package);

        //IQueryable<Package> GetPackagesWithRecipientAndStatus();

        private List<PandaUser> GetTestUsers()
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

        private List<PackageStatus> GetTestPackageStatuses()
        {
            return new List<PackageStatus>
            {
                new PackageStatus
                {
                     Name = "Pending"
                },
                new PackageStatus
                {
                      Name = "Shipped"
                },
                 new PackageStatus
                {
                      Name = "Delivered"
                }
            };
        }


        private List<Package> GetTestPackages()
        {
            return new List<Package>
            {
                new Package
                {
                      Description = "TestPackage1",
                      ShippingAddress = "ul. Test1",
                      Weight = 0.100,
                      Recipient =  GetTestUsers()[0],
                      Status = GetTestPackageStatuses().FirstOrDefault(p => p.Name == "Pending")
                },
                new Package
                {
                      Description = "TestPackage2",
                      ShippingAddress = "ul. Test2",
                      Weight = 0.100,
                      Recipient = GetTestUsers()[1],
                      Status = GetTestPackageStatuses().FirstOrDefault(p => p.Name == "Pending")
                }
            };
        }

        private void SeedTestData(PandaDbContext context)
        {
            context.Users.AddRange(GetTestUsers());
            context.PackageStatus.AddRange(GetTestPackageStatuses());
            context.Packages.AddRange(GetTestPackages());
            context.SaveChanges();
        }

        [Fact]
        public void TestGetAllUsers_WithTwoTestUsers_ShouldReturnAllUsers()
        {
            var options = new DbContextOptionsBuilder<PandaDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new PandaDbContext(options);

            SeedTestData(context);

            var service = new PackagesService(context);

            var expectedData = GetTestPackages();
            var actualData = service.GetPackagesWithRecipientAndStatus();

            Assert.Equal(expectedData.Count, actualData.Count());

            foreach (var package in actualData)
            {
                Assert.True(expectedData.Any(p => package.Recipient.UserName == p.Recipient.UserName
                && package.Status.Name == p.Status.Name),
                 "PackagesService GetPackagesWithRecipientAndStatus() method not correct!");
            }
        }
    }
}
