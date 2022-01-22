namespace CsIterator
{
    internal class ConcreteIterator : AbstractIterator
    {
        private AbstractCollection itemsCollection;
        private Item item;

        public ConcreteIterator(AbstractCollection itemsCollection)
        {
            this.itemsCollection = itemsCollection;
        }

        public override Item CurrentItem()
        {
            return item;
        }

        public override void First()
        {
            item = itemsCollection.Index(0);
        }

        public override void Siguiente()
        {
            item = itemsCollection.Index(itemsCollection.Posicion() + 1);
        }

        public override bool TieneSiguiente()
        {
            if(itemsCollection.Count() > itemsCollection.Posicion() + 1)
            {
                return true;
            }
            return false;
        }
    }
}