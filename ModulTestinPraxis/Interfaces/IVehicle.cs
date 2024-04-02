using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulTestinPraxis.Interfaces
{
    public interface IVehicle
{
    string Id { get; }
    int Capacity { get; } // Maximale Kapazität an Containern, die das Fahrzeug transportieren kann.
    int CurrentLoad { get; } // Aktuelle Anzahl an Containern im Fahrzeug.
    string CurrentLocation { get; } // Aktuelle Position des Fahrzeugs als String.
    bool AcceptOrder(ITransportOrder order); // Versucht, einen Transportauftrag anzunehmen.
    void ExecuteOrder(); // Führt den aktuellen Auftrag aus.
}


}
