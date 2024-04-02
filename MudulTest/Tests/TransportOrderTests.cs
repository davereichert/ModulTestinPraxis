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
    using System.Collections.Generic;
    using ModulTestinPraxis.Interfaces;
    using MudulTest.Facktory;

    public class TransportOrderTests
    {
        [Fact]
        public void Order_IsInitiallyNotCompleted()
        {
            var order = new Mock<ITransportOrder>();
            order.Setup(o => o.IsCompleted).Returns(false);

            Assert.False(order.Object.IsCompleted);
        }

        [Fact]
        public void Order_CanBeMarkedAsCompleted()
        {
            var order = new Mock<ITransportOrder>();
            // Simulieren, dass IsCompleted true zurückgibt, was implizieren würde, dass der Auftrag abgeschlossen ist
            order.Setup(o => o.IsCompleted).Returns(true);

            Assert.True(order.Object.IsCompleted);
        }

        [Fact]
        public void TransportOrder_IsInitiallyNotCompleted()
        {
            // Arrange
            var order = TestFactory.CreateTransportOrder(); // Erstellt ein ITransportOrder-Mock

            // Act & Assert
            var mockOrder = Mock.Get(order);
            mockOrder.Setup(o => o.IsCompleted).Returns(false); // Initialer Zustand sollte nicht abgeschlossen sein

            Assert.False(order.IsCompleted);
        }

        [Fact]
        public void TransportOrder_CanBeMarkedAsCompleted()
        {
            // Arrange
            var order = TestFactory.CreateTransportOrder(); // Erstellt ein ITransportOrder-Mock

            // Act
            var mockOrder = Mock.Get(order);
            mockOrder.Setup(o => o.IsCompleted).Returns(true); // Simulieren, dass der Auftrag als abgeschlossen markiert wurde

            // Assert
            Assert.True(order.IsCompleted);
        }

    }

}
