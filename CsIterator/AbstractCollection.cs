using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsIterator
{
    public abstract class AbstractCollection
    {
        public abstract AbstractIterator CreateIterator();
        public abstract void Agregar(Item item);
        public abstract Item Index(int index);
        public abstract int Count();
        public abstract int Posicion();
    }
}
