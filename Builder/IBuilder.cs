namespace Builder
{
    public interface IBuilder
    {
        void BuildChassis();

        void BuildBody();

        void BuildSeats();

        void BuildEngine();

        void BuildSpoiler();

        void BuildGoFasterStripes();
    }
}
