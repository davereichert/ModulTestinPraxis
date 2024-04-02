using ModulTestinPraxis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulTestinPraxis.Models
{
    public class Vehicle : IVehicle
    {
        public string Id { get; private set; }
        public int Capacity { get; private set; }
        public int CurrentLoad { get; private set; }
        public string CurrentLocation { get; private set; }

        public Vehicle(int capacity)
        {
            Id = Guid.NewGuid().ToString();
            Capacity = capacity;
            CurrentLoad = 0;
            CurrentLocation = "StartLocation";
        }

        public bool AcceptOrder(ITransportOrder order)
        {
            // Einfache Logik zur Überprüfung der Kapazität
            if (Capacity - CurrentLoad >= order.ContainerIds.Count)
            {
                CurrentLoad += order.ContainerIds.Count;
                return true;
            }
            return false;
        }

        public void ExecuteOrder()
        {
            // Implementieren Sie die Logik, um die Ausführung eines Auftrags zu simulieren
            // Zum Beispiel könnte CurrentLocation geändert werden
        }
    }

}
