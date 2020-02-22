namespace DevFactoryZ.SchemeExpert._2D
{
    public class LocationChangedEventArgs
    {
        public LocationChangedEventArgs(ILocation current, ILocation previous)
        {
            Current = current;
            Previous = previous;
        }

        public ILocation Current { get; }

        public ILocation Previous { get; }
    }
}
