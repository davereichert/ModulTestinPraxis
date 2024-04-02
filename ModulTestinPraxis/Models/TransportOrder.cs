using ModulTestinPraxis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulTestinPraxis.Models
{
    public class TransportOrder : ITransportOrder
    {
        public string Id { get; private set; }
        public string PickupLocation { get; private set; }
        public string DeliveryLocation { get; private set; }
        public List<string> ContainerIds { get; private set; }
        public bool IsCompleted { get; private set; }

        public TransportOrder(string pickupLocation, string deliveryLocation, List<string> containerIds)
        {
            Id = Guid.NewGuid().ToString();
            PickupLocation = pickupLocation;
            DeliveryLocation = deliveryLocation;
            ContainerIds = containerIds;
            IsCompleted = false;
        }

        // Möglicherweise benötigen Sie eine Methode, um den Auftrag als abgeschlossen zu markieren
        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }
    }

}
