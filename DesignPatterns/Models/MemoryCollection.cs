using System.Collections.Generic;

namespace DesignPatterns.Models
{
    // Clase creada para emplear el Patrón Singleton
    public class MemoryCollection
    {
        // Variable estática para almacenar la única instancia de la clase (Singleton)
        private static MemoryCollection _instance;

        public ICollection<Vehicle> Vehicles { get; set; }
        public MemoryCollection()
        {
            // Inicializa la colección de vehículos como una lista vacía
            Vehicles = new List<Vehicle>();
        }

        // Método estático que proporciona acceso a la única instancia de la clase
        public static MemoryCollection Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MemoryCollection();
                return _instance;
            }
        }
    }
}
