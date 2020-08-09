﻿using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MLOps.NET.Entities.Impl;
using MLOps.NET.Storage.Database;
using MLOps.NET.Storage.EntityConfiguration;
using MLOps.NET.Storage.Interfaces;
using MLOps.NET.Storage.Repositories;
using MLOps.NET.Utilities;
using Moq;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MLOps.NET.Tests
{
    [TestCategory("UnitTests")]
    [TestClass]
    public class DeploymentRepositoryTests
    {
        private Mock<IClock> clockMock;
        private DbContextFactory contextFactory;
        private IDeploymentRepository sut;

        [TestInitialize]
        public void Initialize()
        {
            var options = new DbContextOptionsBuilder<MLOpsDbContext>()
                .UseInMemoryDatabase(databaseName: "MLOpsNET")
                .Options;

            this.contextFactory = new DbContextFactory(options, RelationalEntityConfigurator.OnModelCreating);

            this.clockMock = new Mock<IClock>();

            this.sut = new DeploymentRepository(contextFactory, clockMock.Object);
        }

        [TestMethod]
        public async Task CreateDeploymentTarget_ShouldSetCreatedDate()
        {
            //Arrange
            var now = DateTime.Now;
            this.clockMock.Setup(x => x.UtcNow).Returns(now);

            //Act
            await this.sut.CreateDeploymentTargetAsync("Production");

            //Assert
            using var db = this.contextFactory.CreateDbContext();
            var deploymentTarget = db.DeploymentTargets.First();

            deploymentTarget.CreatedDate.Should().Be(now);
        }

        [TestMethod]
        public async Task CreateDeployment_ShouldSetDeployedDate()
        {
            //Arrange
            var now = DateTime.Now;
            this.clockMock.Setup(x => x.UtcNow).Returns(now);

            //Act
            await this.sut.CreateDeploymentAsync(new DeploymentTarget("Prod"), new RegisteredModel(), "By me");

            //Assert
            using var db = this.contextFactory.CreateDbContext();
            var deployment = db.Deployments.First();

            deployment.DeploymentDate.Should().Be(now);
        }
    }
}