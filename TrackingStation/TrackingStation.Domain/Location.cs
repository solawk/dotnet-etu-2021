namespace TrackingStation.Domain
{
    public struct Location
    {
        public State type { get; set; }

        public Body refBody { get; set; }
    }

    public enum State
    {
        ORBITING,
        ESCAPING,
        SUBORBITAL,
        LANDED
    }
}