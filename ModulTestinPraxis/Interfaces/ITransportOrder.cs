using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulTestinPraxis.Interfaces
{
    public interface ITransportOrder
    {
        string Id { get; }
        string PickupLocation { get; } // Abfertigungsstandort als String.
        string DeliveryLocation { get; } // Zielstandort als String.
        List<string> ContainerIds { get; } // Liste der IDs der zu transportierenden Container.
        bool IsCompleted { get; } // Gibt an, ob der Auftrag abgeschlossen ist.
    }


}
