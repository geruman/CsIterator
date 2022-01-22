using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsIterator
{
    public class ItemsCollection:AbstractCollection
    {
        private List<Item> listaItems = new List<Item>();
        private Item item;
        private int posicion;

        public override void Agregar(Item item)
        {
            listaItems.Add(item);
        }

        public override int Count()
        {
            return listaItems.Count();
        }

        public override AbstractIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public override Item Index(int index)
        {
            item = listaItems[index];
            posicion = index;
            return item;
        }

        public override int Posicion()
        {
            return posicion;
        }
    }
}
