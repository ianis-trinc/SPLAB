namespace SPLAB
{
    internal abstract class Element
    {
        public abstract void Add(Element element);
        public abstract void Remove(Element element);
        public abstract Element Get(int index);
        public abstract void Print();
    }
}
