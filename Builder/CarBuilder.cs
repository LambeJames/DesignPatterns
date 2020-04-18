namespace Builder
{
    public class CarBuilder : IBuilder
    {
        private Car _car = new Car();

        public CarBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _car = new Car();
        }

        public void BuildChassis()
        {
            _car.Add("Chassis");
        }

        public void BuildBody()
        {
            _car.Add("Body");
        }

        public void BuildSeats()
        {
            _car.Add("Seats");
        }

        public void BuildEngine()
        {
            _car.Add("Engine");
        }

        public void BuildSpoiler()
        {
            _car.Add("Spoiler");
        }

        public void BuildGoFasterStripes()
        {
            _car.Add("Go Faster Stripes");
        }

        public Car GetCar()
        {
            Car result = _car;

            Reset();

            return result;
        }
    }
}
