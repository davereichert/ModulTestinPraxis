using System;
using ModulTestinPraxis.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudulTest.Moqs
{
    public class VehicleMock : IVehicle
    {
        public string Id => Guid.NewGuid().ToString();
        public int Capacity { get; }
        public int CurrentLoad => 0; // Vereinfachung für das Beispiel
        public string CurrentLocation => "StartLocation";

        public VehicleMock(int capacity)
        {
            Capacity = capacity;
        }

        public bool AcceptOrder(ITransportOrder order)
        {
            // Einfache Logik, die später durch die tatsächliche Implementierung ersetzt wird
            return Capacity - CurrentLoad > 0; // Akzeptiert den Auftrag, wenn genug Kapazität vorhanden ist
        }

        public void ExecuteOrder()
        {
            // Implementierung ausgelassen für das Beispiel
        }
    }

}
