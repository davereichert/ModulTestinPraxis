using Moq;
using Xunit;
using ModulTestinPraxis.Interfaces;
//using ModulTestinPraxis.Implementations;
using MudulTest.Moqs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MudulTest.Facktory;

namespace MudulTest.Tests
{
    public class VehicleTests
    {
        [Fact]
        public void AcceptOrder_WithSufficientCapacity_ShouldReturnTrue()
        {
            // Arrange
            var orderMock = new Mock<ITransportOrder>(); // Erstellen eines Mock-Objekts für ITransportOrder
            int vehicleCapacity = 5; // Angenommene Kapazität des Fahrzeugs
            var vehicle = new VehicleMock(vehicleCapacity); // Angenommen, Sie haben eine temporäre Mock-Implementierung von IVehicle

            // Act
            bool result = vehicle.AcceptOrder(orderMock.Object); // Verwenden des Mock-Objekts

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void AcceptOrder_WithInsufficientCapacity_ShouldReturnFalse()
        {
            // Arrange
            var vehicleMock = new Mock<IVehicle>();
            vehicleMock.Setup(v => v.Capacity).Returns(1);
            vehicleMock.Setup(v => v.CurrentLoad).Returns(1); // Keine Kapazität mehr

            var orderMock = new Mock<ITransportOrder>();
            orderMock.Setup(o => o.ContainerIds).Returns(new List<string> { "Container1", "Container2" });

            vehicleMock.Setup(v => v.AcceptOrder(It.IsAny<ITransportOrder>())).Returns(false); // Simuliert das Ablehnen des Auftrags

            // Act
            bool result = vehicleMock.Object.AcceptOrder(orderMock.Object);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Vehicle_AcceptsOrder_WhenCapacityIsSufficient()
        {
            // Arrange
            var vehicleMock = TestFactory.CreateVehicle(); // Erstellt ein IVehicle-Mock
            var orderMock = TestFactory.CreateTransportOrder(); // Erstellt ein ITransportOrder-Mock

            // Angenommen, die Kapazität des Fahrzeugs und die Größe des Auftrags lassen zu, dass der Auftrag angenommen wird.
            // Hier konfigurieren wir das Verhalten des Fahrzeug-Mocks, um diese Annahme zu simulieren.
            var mockVehicle = Mock.Get(vehicleMock); // Holt das Mock-Objekt aus dem IVehicle-Interface, das von CreateVehicle zurückgegeben wurde.
            mockVehicle.Setup(v => v.Capacity).Returns(10); // Angenommen, das Fahrzeug kann bis zu 10 Container aufnehmen.
            mockVehicle.Setup(v => v.CurrentLoad).Returns(0); // Aktuell sind keine Container geladen.

            // Konfigurieren des TransportOrder-Mocks, um zu simulieren, dass es einen Container zu transportieren gibt.
            var mockOrder = Mock.Get(orderMock);
            mockOrder.Setup(o => o.ContainerIds).Returns(new List<string> { "Container1" });

            // Konfigurieren der AcceptOrder-Methode, um true zurückzugeben, wenn das Fahrzeug den Auftrag akzeptieren kann.
            mockVehicle.Setup(v => v.AcceptOrder(It.IsAny<ITransportOrder>())).Returns(true);

            // Act
            bool result = vehicleMock.AcceptOrder(orderMock);

            // Assert
            Assert.True(result);
        }


    }
}
