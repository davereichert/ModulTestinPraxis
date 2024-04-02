using ModulTestinPraxis.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudulTest.Facktory
{
    public class TestFactory
    {
        public static IVehicle CreateVehicle(bool useMock = true)
        {
            if (useMock)
            {
                var mock = new Mock<IVehicle>();
                // Konfigurieren Sie hier das Mock, zum Beispiel:
                mock.Setup(v => v.Capacity).Returns(10);
                return mock.Object;
            }
            else
            {
                // Rückgabe einer echten Instanz
                // return new Vehicle(10); // Angenommen, Vehicle hat einen Konstruktor, der die Kapazität erwartet
                throw new NotImplementedException("Konkrete Implementierung von IVehicle steht noch aus.");
            }
        }

        public static ITransportOrder CreateTransportOrder(bool useMock = true)
        {
            if (useMock)
            {
                var mock = new Mock<ITransportOrder>();
                // Konfigurieren Sie hier das Mock, z.B.:
                mock.Setup(o => o.IsCompleted).Returns(false);
                return mock.Object;
            }
            else
            {
                // Rückgabe einer echten Instanz
                // return new TransportOrder(/* Konstruktorparameter */);
                throw new NotImplementedException("Konkrete Implementierung von ITransportOrder steht noch aus.");

            }
        }

        public static IContainer CreateContainer(bool useMock = true)
        {
            if (useMock)
            {
                var mock = new Mock<IContainer>();
                // Konfigurieren Sie das Mock-Objekt nach Bedarf
                mock.Setup(c => c.Id).Returns("Container123"); // Beispiel-ID
                return mock.Object;
            }
            else
            {
                // Hier könnten Sie eine echte Instanz von IContainer zurückgeben
                // return new Container("Container123"); // Beispiel, wenn Sie einen echten Container haben
                throw new NotImplementedException("Echte Implementierung von IContainer steht noch aus.");
            }
        }


        // Fügen Sie weitere Factory-Methoden für andere Klassen hinzu, wie benötigt.
    }
}
