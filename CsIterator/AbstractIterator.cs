namespace CsIterator
{
    public abstract class AbstractIterator
    {
        public abstract void First();
        public abstract void Siguiente();
        public abstract bool TieneSiguiente();
        public abstract Item CurrentItem();
    }
}