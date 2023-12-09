using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenC_.models
{
    internal class CustomObjectNameComparer : IEqualityComparer<CustomObject>
    {
        public bool Equals(CustomObject x, CustomObject y)
        {
            // Comparar por nombre
            return x.Name == y.Name;
        }
        public int GetHashCode(CustomObject obj)
        {
                // Obtener un código hash basado en el nombre
                return (obj.Name).GetHashCode();
        }
    }
}
