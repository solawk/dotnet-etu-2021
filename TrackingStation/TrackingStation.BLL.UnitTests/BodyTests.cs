using NUnit.Framework;
using System.Threading.Tasks;
using TrackingStation.Domain.Model;
using Moq;
using AutoFixture;
using FluentAssertions;
using TrackingStation.DataAccess.Declaration;
using TrackingStation.Domain;
using TrackingStation.BLL.Implementation;
using System;

namespace TrackingStation.BLL.UnitTests
{
    public class BodyTests
    {
        [Test]
        public async Task CreateBody_Normal_CreatesNewBody()
        {
            BodyModel body = new BodyModel();
            Body newBody = new Body();

            var BodyDA = new Mock<IBodyDataAccess>();
            BodyDA.Setup(x => x.InsertAsync(body)).ReturnsAsync(newBody);

            var BodyBL = new BodyServant(BodyDA.Object);

            var result = await BodyBL.Create(body);

            result.Should().Be(newBody);
        }

        [Test]
        public async Task CreateBody_NullName_ThrowsException()
        {
            Fixture fixture = new Fixture();
            BodyModel body = new BodyModel { BodyName = null };
            var exceptionMessage = fixture.Create<string>();

            var BodyDA = new Mock<IBodyDataAccess>();
            BodyDA.Setup(x => x.InsertAsync(body)).Throws(new Exception(exceptionMessage));

            var BodyBL = new BodyServant(BodyDA.Object);

            var action = new Func<Task>(() => BodyBL.Create(body));

            await action.Should().ThrowAsync<Exception>().WithMessage(exceptionMessage);
        }
    }
}