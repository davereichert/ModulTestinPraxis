using System;
using ModulTestinPraxis.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudulTest.Tests
{
    using Xunit;
    using Moq;
    using MudulTest.Facktory;

    public class ContainerTests
    {
        [Fact]
        public void Container_HasUniqueId()
        {
            var container = new Mock<IContainer>();
            string expectedId = "uniqueId123";
            container.Setup(c => c.Id).Returns(expectedId);

            Assert.Equal(expectedId, container.Object.Id);
        }

        [Fact]
        public void Container1_HasUniqueId()
        {
            // Arrange
            var container = TestFactory.CreateContainer(); // Erstellt ein IContainer-Mock

            // Act & Assert
            var mockContainer = Mock.Get(container);
            string expectedId = "Container123";
            mockContainer.Setup(c => c.Id).Returns(expectedId);

            Assert.Equal(expectedId, container.Id);
        }
    }

}
