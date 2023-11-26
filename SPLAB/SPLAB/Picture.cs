namespace SPLAB
{
    internal struct Dimension { public float height; public float width; }

    internal abstract class Picture
    {
        public abstract string url();
        public abstract Dimension dim();
        public abstract Image content();
    }
}
